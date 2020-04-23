using System;
using Xunit;

namespace GradeBook.Tests
{   
    public delegate string WriteLogDelegate(string logMassage);

    public class TypeTests
    {   
        int count =0; 

        [Fact]
        public void WriteLogDelegate()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += incrementCount;


            var result = log("Hello!");
            Assert.Equal(3, count);
        }

        string incrementCount(string message)
        {
            count++;
            return message.ToLower();
        }

        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void StringBehaveLikeValueTypes()
        {
            string name ="David";
            var upper = MakeUppercase(name);

            Assert.Equal("DAVID", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }


        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CsharpCanPassByValue()
        {
           var book1 = GetBook("Book 1");
           GetBookRefName(ref book1, "New Name");

           Assert.Equal("New Name", book1.Name);
        }

        private void GetBookRefName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CsharpIsPassByValue()
        {
           var book1 = GetBook("Book 1");
           GetBookSetName(book1, "New Name");

           Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CanSetNameFromeReference()
        {
           var book1 = GetBook("Book 1");
           SetName(book1, "New Name");

           Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentOdjects()
        {
           var book1 = GetBook("Book 1");
           var book2 = book1;
        

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        InMemoryBook GetBook (string name)
        {
            return new InMemoryBook(name);
        }
    }
}
