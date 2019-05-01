//IF A USER IS SELECTED THAT ALREADY HAS A SCHEDULE, THE VIEW SHOULD BE POPULATED BY THAT SCHEDULE 

// set shift templates to viewdata
ViewData["shifttemplates"] = GetShiftTemplates();
 return PartialView("_scheduleShiftsTable", model);{





//this schedule is blank schedule created if the Id is template
{
    ScheduleViewModel scheduleVM;
      if (Id == "template"){
          scheduleVM = new ScheduleViewModel();
      }





//user with Schedule using users sechedule
      else
      {
           if (db.Users.Find(Id).Schedules.Count != 0)

            {
                var Schedule = db.Users.Find(Id).Schedules.FirstOrDefault();
                scheduleVM= new ScheduleViewModel(Schedule);
            }




//else than use user's to make schedule
            else{
                  var user = db.Users.Find(Id);
                   scheduleVM = new ScheduleViewModel(user);

            }
      

        







