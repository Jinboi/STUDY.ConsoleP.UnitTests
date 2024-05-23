using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodeTrackerConfigFirst;

namespace TestProject1
{
    [TestClass]
    
    public class CodeTrackerConfigFirstTests
    {
        [TestMethod]
        public void ValidationTest_UserEnters5_ReturnsTrueThatFinalInputIs5()
        {
            // Arrange
            string message = "\n\nPlease type Id of the record you would like to update. Type 0 to go back to Main Menu.\n\n";

            string userInputs30AndEnters = "5\n"; 
            StringReader recordIdInStringValue = new StringReader(userInputs30AndEnters);
            Console.SetIn(recordIdInStringValue);

            // Act
            int finalInput = Validation.GetNumberInput(message);

            // Assert
            Assert.AreEqual(5, finalInput);
        }

        /*

        [TestMethod]
        public void GetNumberInput_InputIsNotNumber_FormatExceptionThrown()
        {
            // Arrange
            string message = "Please enter a number:";
            string userInput = "five";
            StringReader stringReader = new StringReader(userInput);
            Console.SetIn(stringReader);

            // Act
            Action act = () => Validation.GetNumberInput(message);

            // Assert
            Assert.ThrowsException<FormatException>(act);
        }

        */

        /*

        [TestMethod]
        public void ValidationTest_UserEnters0_ReturnsTrueThatreturnToMainMenuTriggered()
        {
            // Arrange
            string message = "\n\nPlease type Id of the record you would like to update. Type 0 to go back to Main Menu.\n\n";

            string userInputs0AndEnters = "0\n"; 
            StringReader recordIdInStringValue = new StringReader(userInputs0AndEnters);
            Console.SetIn(recordIdInStringValue);

            // Act
            int finalInput = Validation.GetNumberInput(message);

            // Assert
            Assert.AreNotEqual(0, finalInput);
        }
        
        */
    }
}