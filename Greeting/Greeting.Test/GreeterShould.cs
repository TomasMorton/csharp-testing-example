using System.Collections.Generic;
using Xunit;

namespace Greeting.Test
{
    public class GreeterShould
    {
        private Greeter _greeter;

        public GreeterShould()
        {
            _greeter = new Greeter();    
        }
        
        [Fact]
        public void PrintName()
        {
            var name = "Bob";
            
            var printResult = _greeter.Greet(name);
            
            Assert.Equal($"Hello, {name}.", printResult);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void PrintFriendlyGreetingWhenNameIsMissing(string missingName)
        {
            var printResult = _greeter.Greet(missingName);
            
            Assert.Equal("Hello, my friend.", printResult);
        }

        [Fact]
        public void ShoutWhenShoutedAt()
        {
            var shoutedName = "JERRY";

            var printResult = _greeter.Greet(shoutedName);
            
            Assert.Equal($"HELLO {shoutedName}!", printResult);
        }

        [Fact]
        public void GreetTwoPeople()
        {
            var jill = "Jill";
            var jane = "Jane";
            
            var printResult = _greeter.Greet(jill, jane);
            
            Assert.Equal($"Hello, {jill} and {jane}.", printResult);
        }

        [Fact]
        public void GreetMoreThanTwoPeople()
        {
            var jill = "Jill";
            var jane = "Jane";
            var jack = "Jack";

            var printResult = _greeter.Greet(jill, jane, jack);
            
            Assert.Equal($"Hello, {jill}, {jane}, and {jack}.", printResult);
        }

        [Fact]
        public void SplitNamesContainingCommas()
        {
            var splitNames = "Jack, Jill, Jane";

            var printResult = _greeter.Greet(splitNames);
            
            Assert.Equal("Hello, Jack, Jill, and Jane.", printResult);
        }

        [Fact]
        public void SpeakAndShoutAtTheSameTime()
        {
            var amyTalking = "Amy";
            var brianShouting = "BRIAN";
            var charlotteTalking = "Charlotte";
            
            var printResult = _greeter.Greet(amyTalking, brianShouting, charlotteTalking);
            
            Assert.Equal(
                $"Hello, {amyTalking} and {charlotteTalking}. AND HELLO {brianShouting}!",
                printResult);
        }
    }
}