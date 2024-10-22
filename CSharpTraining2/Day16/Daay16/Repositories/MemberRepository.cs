using Daay16.Data;
using Daay16.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daay16.Repositories
{
    internal class MemberRepository
    {
        public GenericResponse<List<Member>> GetAllMembers()
        {
            var members = DataStore.Members;
            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = members,
            };
        }

        public GenericResponse<Member> GetMemberById(int id)
        {
            var member = DataStore.Members.FirstOrDefault(x => x.Id == id);
            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member,
            };
        }

    }
}

