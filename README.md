# TechJobsOOAutoGraded6 Solution

This solution contains a branch for each major task.

## Task 2: Complete Support Classes
solution for only this section found on `task2` branch

We ask students to complete the `Location`, `CoreCompetency`, and `PostionType` classes.
If students use the Generator Shortcuts to set these up they may add extra lines of code, but should still pass.
Students can also use `Employer` class as a reference.

At this time, all Autograding tests have been commented out.  

Students will need to uncomment `TaskTest2` in order to run the autograded tests.  Have them look for the `TODO` statements within the test class.

There are 8 tests in TaskTest2.

### Autograded Tests: 
**Location Tests:**
- `Test_Second_Location_Constructor_Exists()` This test is checking the class for a non-empty constructor.  
- `Test_Second_Location_Constructor_Initializes_Value()` This test is creates a location object and then tries to update the value.  Testing the setter.
- `Test_Second_Location_Constructor_Initializes_Id()` This test checks that an Id has been assigned.

**CoreCompetency Tests**
- `Test_CoreCompetency_Accessor_SetUp()`  This test is looking for getters related to Id.  
- `Test_CoreCompetency_Has_No_Id_Setter_SetUp()`  This test is making sure that the Id does not have a setter, and can not be set outside initalization.

**PositionType Tests**

These tests are looking for the methods by name.  
- `Test_PositionType_Equals_Method_SetUp()` 
- `Test_PositionType_HashCode_SetUp()`
- `Test_PositionType_ToString_SetUp()`
