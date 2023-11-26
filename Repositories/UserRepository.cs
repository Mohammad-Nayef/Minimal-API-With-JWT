﻿using MinimalApiWithJwt.Models;

namespace MinimalApiWithJwt.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<UserDTO> _users = new List<UserDTO>();

        public void Add(UserDTO user) => _users.Add(user);

        public UserDTO Get(Guid userId) => _users.Find(user => user.Id == userId);

        public IEnumerable<UserDTO> GetAll() => new List<UserDTO>(_users);

        public void Update(UserDTO updatedUser)
        {
            var user = Get(updatedUser.Id);
            user = updatedUser;
        }

        public void Delete(UserDTO user) => _users.Remove(user);
    }
}
