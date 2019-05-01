//Show "approved", "pending", or "denied" on the admin TOE Request Page jsut like the user TOE Request Page

//Use if and Else statement for spearting 'NULL == filtering'

var filtered = new List<TimeOffEvent>();
if (filter == null || filter == ""){
   //remove var unfiltered = new List<TimeOffViewModel>();
   ViewBag.filtertype = "";
   //remove foreach (var record in db.TimeOffEvents.ToList())
   //remove { unfiltered.Add(new TimeOffViewModel(record));
   filtered = db.TimeOffEvents.ToList();}
   //remove return PartialView("_Index", unfiltered);}





//GRAB EVENTS WITH FILTER
else{
    var filtered = new List<TimeOffEvent>();
    filtered = db.TimeOffEvents.ToList();
    break;
    
    }
}


//Use if and Else statement for spearting 'Processed And Pending'
List<TimeOffViewModel> timeOffList = new List<TimeOffViewModel>();

 if (data == "index"){
     //remove filtered = filtered.Where(x => x.User.Id == null).OrderBy(a => a.Start).ToList();
    filtered = filtered.Where(x => x.ActiveSchedule == null).OrderBy(a => a.Start).ToList();
 }
 //remove  else if (data == "processsed")
 else if (data == "processed"){
     //remove filtered = filtered.Where(x => x.User.Id != null).OrderBy(a => a.Start).ToList();
     filtered = filtered.Where(x => x.ActiveSchedule != null).OrderBy(a => a.Start).ToList()

 }

//ALSO CHANGE THE PARTIALVIEW PREMETER VALUE TO FALSE TO NULL FOR CORRECT FUNTIONALITY of STATUS of request
(_Index.cshtml)
//remove @{ if (item.ActiveSchedule == false
@{ if (item.ActiveSchedule == null){
     <p>Denied</p>
}










