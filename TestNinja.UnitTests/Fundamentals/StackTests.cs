﻿using System;
using NUnit.Framework;
using System.Collections.Generic;


namespace TestNinja.Fundamentals
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_ArgIsNull_ThrowNullException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);


        }

        [Test]
        public void Push_ValidArg_AddTheObjectToTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));

        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Stack<string>();
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithFewObjects_ReturnsTheObjectOnTheTop()
        {
            //arrange
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            //act
            var result = stack.Pop();

            //assert

            Assert.That(result, Is.EqualTo("c"));
        }
        [Test]
        public void Pop_StackWithFewObjects_RemoveTheObjectOnTheTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
        }
        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Stack<String>();
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }
        [Test]
        public void Peek_StackWithObjects_ReturnObjectOnTopOfTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("c"));

        }
        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveTheObjectsOnTopOfTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));


        }


    }
}
