# 413_Project_One

Made by The Wizards:
Nefi Perez
Drew Luke
Joseph Vore
Isaac Corcoran

IS 413 – Hilton
Project #1
Rob & Renae Hilton (my parents) are currently serving a mission inthe Layton Utah mission.
One of the missionary efforts is to do tours of the Layton Utah temple site.  
Currently the web app they useis an app called SignUpGenius which is a little clunky and 
difficultto use: https://www.signupgenius.com/go/10c0d4ba4ae2caaf5c61-laytonFor our 
project, we will write an app to replacethe need forSignUpGenius.  The app will consist 
of (at least) four separate pages: 

•Home Page:  This page will have a picture of the temple and the basic information
 regarding the tour, along with the ability to click a button to “Sign Up” for a tour

•Sign Up Page:  This page will display the available times.  Ignore the time slots on the 
SignUpGenius page.  For our purposes, we will say the tours occurevery hour on the hour 
from 8:00 am –8:00 pm (i.e. the last tour starts at 8:00 pm.)Once the user selects a time, 
they are routed to a form that has the date info set, but allows the user to enter their 
info.

•Form:  Once the user has selected a time, they will fill out a form that has the time set 
(i.e. part of theform, but not editable), but also allows the user to enter their 
information: 
o Name of GroupoSize of Group 
o Email AddressoPhone Number(Optional) When the user submits the data, we want to store 
their contact information and update the database to show thattime slot as taken. After 
submitting the form, the user should be returned to the Home Page.

•View AppointmentsPage:  This page will list out all of the appointments that have been made.
(No need to edit or delete appointmentsfor this assignment.)Assign each member of your team 
one offour specialties, which I have attempted to divide up as evenly as possible:
1:  Models/ Database/ Setup:  This individual will build the models and set up the database.
They will also build the view that allows the user to build appointments. They will populate 
the database with any needed info.They will also configure all the needed settings.

2:  Controllers / HomePage View/ Project Manager:  This individual will be responsible for 
the Controllers. They will also set up the Home Page View.They will serve asProjectManagerand 
make sure everybody is on track.  They will notify me of any issues.  They will submit the 
projecton behalf of the group.

3:  Views --Sign Up View / Form:  This individual will be responsible for creating the Sign 
Up View and theability for the user to fill out aform to sign up for a specific time.

4:Views--View Appointments& SharedLayout:  This individual will be responsible for creating 
the View Appointments view and the Shared Layout. The look and feel should be consistent 
across the site, with the ability to navigate between Home / Sign Up/ and View Appointments.

Work as a team and feel free to help each other out.  However, individuals can only make 
changes for those areas where they are assigned.  In other words, you can look at code together 
and work as a groupto decide the best way to do something, but don’t just jump in and do it for 
the other individual.We want everybody in the group to contribute.  Maybe agood rule of thumb
we could adopt:  Youare only allowed to edit the code you are responsiblefor. Tips-For the time 
slots, I would suggest creating a specific model (table) that only keeps track of available times.
You can then hard code a week’s worth of time slots.  (I’m trying to keep this as simple as 
possible.)  We canmodify the program later to have those time slots dynamically generated.

-Have fun with this project.  
Please do not take it so seriously that it becomes uncomfortable for therest of the team.  
The objective is to work together on something as a team and practice the skills that we have 
learned this semester.I promise that we will be liberal in gradingthe project.  
The “means”in the case of this project is more important than the “ends”.As always, write good 
clean code.  

Please let me know if there are any questions.Submit a link to the GitHub repository containing 
your assignment via Learning Suite.