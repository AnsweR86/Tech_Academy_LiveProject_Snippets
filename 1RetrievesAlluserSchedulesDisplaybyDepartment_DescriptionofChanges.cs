//REWRITE THE QUERY TO WORK WITH THE NEW MODEL SO TRHAT IT RETRIEVES ALL USER SCHEDULES 
//WITH SPECIFIED DEPARTMENT FOR MUTILPLE USERS

        // important to do both in single loop to ensure user schedules at timeoffevents are in sync in both lists
         public ActionResult Index(){
            return View("~/Views/Shared/Calendar/_index.cshtml");
            {
        //THIS IS QUERY TO WORK WITH THE NEW MODEL SO IT GETS ALL USER SCHEDULES WITH THE SPECIFIED DEPT.
                Schedule userSchedule = db.Schedules.Where(x => x.Users.Select(i => i.Id).Contains(Id)).FirstOrDefault();
                
                userSchedules.Add(userSchedule);

        //THIS QUERY WORK WITH SCHEDULES AND TIMEOFFREQUEST AND PARSE ALL EVENTS AND SCHEDULES
                 List<TimeOffEvent> userTimeOffRequests = db.TimeOffEvents.Where(TOE => TOE.User.Id == Id).AsEnumerable().ToList();



                    deptTimeOffEvents.Add(userTimeOffRequests);
            }
         




     










                

