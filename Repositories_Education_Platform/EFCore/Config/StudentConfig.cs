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
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(new Student{
            StudentId = 1,
            StudentName = "Name",
            StudentSurname = "Surname",
            StudentEmail = "student@email.com"
            });
        }
    }
}
