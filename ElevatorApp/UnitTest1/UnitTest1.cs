using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElevatorApp;

namespace ElevatorApp.Domain
{
    [TestClass]
    public class UnitTest1
    {
        static int bottomfloor = -2;
        const int topfloor = 3;
        private const int untilmaintainance = 6;

        readonly public Elevator elevator = new Elevator("Kalle", bottomfloor, topfloor, 1, 6);

        // Testar "Should [be in some state] [after/before/when] [action takes place]"

        [TestMethod]
        public void elevator_should_be_at_floor_one_when_thats_its_startfloor()
        {
            Assert.AreEqual(1, elevator.currentFloor);
        }

        [TestMethod]
        public void elevator_should_be_at_level_2_when_it_starts_at_1_and_go_up_one_floor()
        {
            elevator.GoUp();
            Assert.AreEqual(2, elevator.currentFloor);
        }

        [TestMethod]
        public void elevator_should_be_at_level_0_when_it_starts_at_1_and_go_down_one_floor()
        {
            elevator.GoDown();
            Assert.AreEqual(0, elevator.currentFloor);
        }

        [TestMethod]
        public void elevaror_should_be_at_level_3_when_it_starts_at_1_and_go_up_is_called_twice()
        {
            elevator.GoUp();
            elevator.GoUp();
            Assert.AreEqual(3, elevator.currentFloor);
        }

        [TestMethod]
        public void elevator_should_be_at_top_floor_when_go_up_is_called_really_many_times()
        {
            for (int i = 0; i < 1000; i++)
                elevator.GoUp();

            Assert.AreEqual(topfloor, elevator.currentFloor);
        }

        [TestMethod]
        public void elevator_should_be_at_bottom_floor_when_go_down_is_called_really_many_times()
        {
            for (int i = 0; i < 100; i++)
                elevator.GoDown();

            Assert.AreEqual(bottomfloor, elevator.currentFloor);
        }
 
    }
}
