//Nulliable boolian logic
//whether or  not the event is active on the schedule Datetime event is displyed

 [Display(Name = "Active")]
 public bool? ActiveSchedule { get; set; }

 this.Submitted = timeOffEvent.Submitted;






//if not set, imply property to be "null/pending"
this.ActiveSchedule = timeOffEvent.ActiveSchedule; 





