using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using test2;
using System;

[TestFixture]
public class StudentsManagementSystemTests
{
    private StudentsManagementSystem system;

    [SetUp]
    public void Setup()
    {
        system = new StudentsManagementSystem();
    }

    [Test]
    public void AddStudent_AddsNewStudentToHashtable()
    {
        // Arrange
        Student student = new Student(1, "John Doe", "Male", 20, "Class A");
        student.MarkList[0] = 80;
        student.MarkList[1] = 75;
        student.MarkList[2] = 90;

        // Act
        system.AddStudent(student);

        // Assert
        Assert.IsTrue(system.StudentHashtable.ContainsKey(student.StudID));
        Assert.AreEqual(student, system.StudentHashtable[student.StudID]);
    }

    [Test]
    public void PrintAllStudents_CallsPrintMethodOfAllStudents()
    {
        // Arrange
        Student student1 = new Student(1, "John Doe", "Male", 20, "Class A");
        Student student2 = new Student(2, "Jane Smith", "Female", 19, "Class B");
        system.AddStudent(student1);
        system.AddStudent(student2);

        // Act
        system.PrintAllStudents();

        // Assert
        Assert.AreEqual("1. John Doe - Male - 20 - Class A", system.PrintedOutput[0]);
        Assert.AreEqual("2. Jane Smith - Female - 19 - Class B", system.PrintedOutput[1]);
    }

    [Test]
    public void SearchStudentById_ReturnsCorrectStudent()
    {
        // Arrange
        Student student1 = new Student(1, "John Doe", "Male", 20, "Class A");
        Student student2 = new Student(2, "Jane Smith", "Female", 19, "Class B");
        system.AddStudent(student1);
        system.AddStudent(student2);

        // Act
        Student result = system.SearchStudentById(2);

        // Assert
        Assert.AreEqual(student2, result);
    }

    [Test]
    public void SearchStudentByName_ReturnsCorrectStudent()
    {
        // Arrange
        Student student1 = new Student(1, "John Doe", "Male", 20, "Class A");
        Student student2 = new Student(2, "Jane Smith", "Female", 19, "Class B");
        system.AddStudent(student1);
        system.AddStudent(student2);

        // Act
        List<Student> results = system.SearchStudentByName("John");

        // Assert
        Assert.AreEqual(1, results.Count);
        Assert.AreEqual(student1, results[0]);
    }

    [Test]
    public void SearchStudentByClass_ReturnsCorrectStudentsInAlphabeticalOrder()
    {
        // Arrange
        Student student1 = new Student(1, "John Doe", "Male", 20, "Class B");
        Student student2 = new Student(2, "Jane Smith", "Female", 19, "Class A");
        Student student3 = new Student(3, "Adam Johnson", "Male", 21, "Class A");
        system.AddStudent(student1);
        system.AddStudent(student2);
        system.AddStudent(student3);

        // Act
        List<Student> results = system.SearchStudentByClass("Class A");

        // Assert
        Assert.AreEqual(2, results.Count);
        Assert.AreEqual(student3, results[0]);
        Assert.AreEqual(student2, results[1]);
    }

    [Test]
    public void QuitProgram_SetsIsRunningToFalse()
    {
        // Act
        system.QuitProgram();

        // Assert
        Assert.IsFalse(system.IsRunning);
    }
}
