using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

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

        private void GetBookRefName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CsharpIsPassByValue()
        {
           var book1 = GetBook("Book 1");
           GetBookSetName(book1, "New Name");

           Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromeReference()
        {
           var book1 = GetBook("Book 1");
           SetName(book1, "New Name");

           Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
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

        Book GetBook (string name)
        {
            return new Book(name);
        }
    }
}
