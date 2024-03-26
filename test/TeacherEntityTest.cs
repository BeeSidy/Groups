namespace Teachers.Tests
{
    [TestClass]
    public class TeacherEntityTests
    {
        [TestMethod]
        public void TeacherEntity_Initialization_ShouldSucceed()
        {
            // Arrange
            var teacher = new Teachers.Entities.TeacherEntity
            {
                Name = "Jane Smith",
                Age = 35,
                Department = "Mathematics"
            };

            // Act
            string expectedName = "Jane Smith";
            int expectedAge = 35;
            string expectedDepartment = "Mathematics";

            // Assert
            Assert.AreEqual(expectedName, teacher.Name);
            Assert.AreEqual(expectedAge, teacher.Age);
            Assert.AreEqual(expectedDepartment, teacher.Department);
        }
    }
}