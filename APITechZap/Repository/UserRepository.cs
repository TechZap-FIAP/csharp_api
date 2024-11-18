﻿using APITechZap.Data;
using APITechZap.Models;
using APITechZap.Models.DTOs;
using APITechZap.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace APITechZap.Repository;

/// <summary>
/// User Repository
/// </summary>
public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _dbContext;

    /// <summary>
    /// Constructor for UserRepository
    /// </summary>
    /// <param name="dbContext"></param>
    public UserRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Get all Users
    /// </summary>
    /// <returns>Return All Users</returns>
    /// <exception cref="Exception">Usuários não encontrados!</exception>
    public async Task<IEnumerable<UserDetailedDTO>> GetAllUsersAsync()
    {
        var users = await _dbContext.Users.Where(u => u.DtDeletedAt == null).Include(u => u.UserAdditionalData).Include(u => u.Address).ToListAsync() ?? throw new Exception("Usuários não encontrados!"); ;

        var userDTOs = users.Select(u => new UserDetailedDTO
        {
            DsName = u.DsName,
            DsSurname = u.DsSurname,
            DsEmail = u.DsEmail,
            UserAdditionalDataDTO = u.UserAdditionalData != null ? new UserAdditionalDataDTO
            {
                DsCPF = u.UserAdditionalData.DsCPF,
                DsPhone = u.UserAdditionalData.DsPhone,
                DtBirthDate = u.UserAdditionalData.DtBirthDate
            } : null,
            AddressDTO = u.Address != null ? new AddressDTO
            {
                DsStreet = u.Address.DsStreet,
                DsNumber = u.Address.DsNumber,
                DsComplement = u.Address.DsComplement,
                DsNeighborhood = u.Address.DsNeighborhood,
                DsCity = u.Address.DsCity,
                DsState = u.Address.DsState,
                DsZipCode = u.Address.DsZipCode
            } : null
        });

        return userDTOs;
    }

    /// <summary>
    /// Get User by ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Return User by Id</returns>
    /// <exception cref="Exception">Usuário não encontrado!</exception>
    public async Task<UserDetailedDTO> GetUserByIdAsync(int id)
    {
        var user = await _dbContext.Users.Include(u => u.UserAdditionalData).Include(u => u.Address).FirstOrDefaultAsync(u => u.IdUser == id && u.DtDeletedAt == null) ?? throw new Exception("Usuário não encontrado ou Excluido!");

        var userDTO = new UserDetailedDTO
        {
            DsName = user.DsName,
            DsSurname = user.DsSurname,
            DsEmail = user.DsEmail,
            UserAdditionalDataDTO = user.UserAdditionalData != null ? new UserAdditionalDataDTO
            {
                DsCPF = user.UserAdditionalData.DsCPF,
                DsPhone = user.UserAdditionalData.DsPhone,
                DtBirthDate = user.UserAdditionalData.DtBirthDate
            } : null,
            AddressDTO = user.Address != null ? new AddressDTO
            {
                DsStreet = user.Address.DsStreet,
                DsNumber = user.Address.DsNumber,
                DsComplement = user.Address.DsComplement,
                DsNeighborhood = user.Address.DsNeighborhood,
                DsCity = user.Address.DsCity,
                DsState = user.Address.DsState,
                DsZipCode = user.Address.DsZipCode
            } : null
        };

        return userDTO;
    }

    /// <summary>
    /// Verify if Email exists
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    public async Task<bool> EmailExistsAsync(string email)
    {
        return await _dbContext.Users.AnyAsync(u => u.DsEmail == email);
    }
}
