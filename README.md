# SVT-Robotics-TakeHome
.Net Core recruiting assessment

TO RUN:
Should be very straightforward:
 1. Clone repo
 2. Open solution in Visual Studio
 2. Run IIS Express green button
 3. Hit POST endpoint http://localhost:6026/RobotRouting/GetRobotForLoad with a JSON body shaped as specced
 4. Serve and Enjoy

NEXT STEPS:
 - I went way overboard with unit testing so that is done now actually. I had fun though.

 - AUTH. I would want a token for any api call

 - It would be best to not store the SVT Url as a string in my repo, that should be an environment variable somehow

 - The x,y coordinate to Vector2 is clumsy, I would look into a way to remove the float properites and only use Vector2