using GrindTasks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GrindTasks.Data.Tests.Models
{
    public class PersonalTaskTests
    {
        private PersonalTask SUT;

        PersonalTaskTests() => SUT = new PersonalTask();

        [Fact]
        public void Given_all_subTasks_are_completed_CompleteTask_returns_true()
        { 
            Assert.True(SUT.CompleteTask());
        }
    }
}
