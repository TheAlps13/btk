using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Schooler.Tests
{

    [TestClass]
    public class StudentManager_Tests
    {
        private StudentManager _studentManager;
        public StudentManager_Tests()
        {
            _studentManager = new();
        }

        [TestInitialize]
        public void SeedData()
        {
            _studentManager.AddStudent(new Student
            {
                Id = 1,
                Name = "Alper",
                LastName = "Tasci"
            });

            _studentManager.AddStudent(new Student
            {
                Id = 2,
                Name = "John",
                LastName = "Kebap"
            });

            _studentManager.AddStudent(new Student
            {
                Id = 3,
                Name = "Kemal",
                LastName = "Brother"
            });
        }

        [TestCleanup]
        public void ClearData()
        {
            _studentManager = new();
        }

        [TestMethod]
        public void Student_Number_And_Order_Should_Be_The_Same()
        {
            // Arrange
            List<SchoolMember> expected = new List<SchoolMember>
            {
                new Student
                {
                    Id = 1,
                    Name = "Alper",
                    LastName = "Tasci"
                },
                 new Student
                {
                    Id = 2,
                    Name = "John",
                    LastName = "Kebap"
                },
                 new Student
                {
                    Id = 3,
                    Name = "Kemal",
                    LastName = "Brother"
                }
            };

            // Act
            List<SchoolMember> actual = new List<SchoolMember>(_studentManager.GetStudents());

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
