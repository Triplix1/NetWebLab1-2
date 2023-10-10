using FluentAssertions;
using System.Collections.Generic;

namespace Lab1.Test
{
    public class MyLinkedListTests
    {
        [Fact]
        public void CreateMyLinkedList_WithoutParams_EmpltyList()
        {
            //Act
            var actialResult = new MyLinkedList<object>();

            //Assert
            actialResult.Count.Should().Be(0);
            actialResult.Head.Should().BeNull();
            actialResult.Tail.Should().BeNull();
        }

        [Fact]
        public void CreateMyLinkedList_WithNullList_ShouldThrowArgumentNullException()
        {
            //Act
            var action = () => new MyLinkedList<object>(null);

            //Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Add_NullParam_ThrowArhumentNullException()
        {
            //Arrange
            var list = new MyLinkedList<object>();

            //Act
            var action = () => list.Add(null);

            //Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Add_FirstValueToEmtyList_HeadEqualTailCount1()
        {
            //Arrange
            var list = new MyLinkedList<object>();

            //Act
            list.Add("dd");

            //Assert
            list.Head.Should().Be(list.Tail);
            list.Count.Should().Be(1);
        }


    }
}