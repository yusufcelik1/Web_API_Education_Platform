using Entities_Education_Platform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Education_Platform.EFCore.Config
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(new Teacher
            {
                TeacherId = 1,
                TeacherName = "Name",
                TeacherSurname = "Surname",
                TeacherEmail = "teacher@email.com"
            });
        }
    }
}
