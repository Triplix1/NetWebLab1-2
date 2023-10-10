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
            list.Head.Value.Should().Be("dd");
            list.Count.Should().Be(1);
        }

        [Fact]
        public void AddToNonEmptyList_SomeValue_CorrectTail()
        {
            //Arrange
            var list = new MyLinkedList<int>(new List<int> { 1, 2, 3 });

            //Act
            list.Add(4);

            //Assert
            list.Head.Previous.Value.Should().Be(4);
            list.Tail.Value.Should().Be(4);
            list.Count.Should().Be(4);
        }

        [Fact]
        public void AddFirst_FirstValueToEmtyList_HeadEqualTailCount1()
        {
            //Arrange
            var list = new MyLinkedList<object>();

            //Act
            list.AddFirst("dd");

            //Assert
            list.Head.Should().Be(list.Tail);
            list.Head.Value.Should().Be("dd");
            list.Count.Should().Be(1);
        }

        [Fact]
        public void AddFirstToNonEmptyList_SomeValue_CorrectHead()
        {
            //Arrange
            var list = new MyLinkedList<int>(new List<int> { 1, 2, 3 });

            //Act
            list.AddFirst(4);

            //Assert
            list.Head.Value.Should().Be(4);
            list.Tail.Next.Value.Should().Be(4);
            list.Count.Should().Be(4);
        }

        [Fact]
        public void AddFirst_NullParam_ThrowArhumentNullException()
        {
            //Arrange
            var list = new MyLinkedList<object>();

            //Act
            var action = () => list.Add(null);

            //Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Clear_ShouldBeEmtyList()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });

            //Act
            list.Clear();

            //Assert
            list.Head.Should().BeNull();
            list.Tail.Should().BeNull();
            list.Count.Should().Be(0);    
        }

        [Fact]
        public void Find_NonContains_Null()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });

            //Act
            var result = list.Find(4);

            //Assert
            result.Should().BeNull();
        }

        [Fact]
        public void Find_Contains_CorrectValue()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });

            //Act
            var result = list.Find(3);

            //Assert
            result.Value.Should().Be(3);
        }

        [Fact]
        public void Remove_NonContainsElement_False()
        {
            //Arrange
            var array = new int[] { 1, 2, 3, };
            var list = new MyLinkedList<int>(array);

            //Act
            var result = list.Remove(4);


            //Assert
            result.Should().Be(false);
            list.ToList().Should().BeEquivalentTo(array);
        }

        [Fact]
        public void Remove_ContainsElement_True()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });

            //Act
            var result = list.Remove(4);

            //Assert
            result.Should().Be(false);
            list.Count.Should().Be(3);
        }

        [Fact]
        public void Contains_NonContains_False()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });

            //Act
            var result = list.Contains(4);

            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Contains_ContainsElement_True()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });

            //Act
            var result = list.Contains(3);

            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void ContainsNode_ContainsNode_True()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });

            //Act
            var result = list.Contains(list.Head);

            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void ContainsNode_NonContainsNode_Flase()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });

            //Act
            var result = list.Contains(new MyLinkedListNode<int>(1));

            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void ContainsNode_NullNode_Flase()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });

            //Act
            var result = list.Contains(null);

            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void CopyTo_ArrayIndexLessThan0_ShouldThrowArgumentOutOfRangeException()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });
            var arr = new int[10];

            //Act
            var action = () => list.CopyTo(arr, -1);

            //Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void CopyTo_ArrayIndexMoreThenArrayLength_ShouldThrowArgumentOutOfRangeException()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });
            var arr = new int[10];

            //Act
            var action = () => list.CopyTo(arr, 12);

            //Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void CopyTo_ArrayIndexMoreThenArrayCapacity_ShouldThrowArgumentException()
        {
            //Arrange
            var list = new MyLinkedList<int>(new int[] { 1, 2, 3, });
            var arr = new int[10];

            //Act
            var action = () => list.CopyTo(arr, 9);

            //Assert
            action.Should().Throw<ArgumentException>();
        }
    }
}