# ASP.NET tutorial

## Database first approach
Contents
<ul type="disc">
	<li><a href="#">Introduction to MVC</a></li>
	<li><a href="#">Form Submission</a></li>
	<li><a href="#">Entity Framework</a></li>
	<li><a href="#">Entity Framework with DTO</a></li>
</ul>

<div>
	<h2>Introduction to MVC</h2>
	<div>
		<img src="screenshots/intromvc_1.jpg" width="60%">
	</div>
	<b>Step - 1</b>
	<p>
	Create <code>PortfolioController</code> first with the necessary methods <code>Bio</code> <code>Education</code> <code>Qualifications</code> <code>References</code>.
	Again create <code>ProductController</code> with the methods <code>Create</code> & <code>List</code>.
	</p>
	<b>Step - 2</b>
	<p>Add views for the created methods. For <code>Portfolio</code> the views are <code>Education</code> <code>Qualifications</code> <code>References</code>
	</p>.
	<b>Step - 3</b>
	<div>
		<img src="screenshots/intromvc_2.jpg" width="60%">
	</div>
	<i>Models -> Add -> Class</i>
	<p>
	Create <code>Degree.cs</code>, <code>Referee.cs</code> in the Models folder created by IDE. These files will contain the properties for initialization
	</p>
	<b>Step - 4</b>
	<p>
	Import <code>using IntroMVC.Models</code> in <code>PortfolioController.cs</code>
	</p>
</div>


## Code first approach
Contents

<h2>Steps for code first approach</h2>
<div>
1. Installing EF to project via nuget (needs internet connection)	(1) <br>
2. Initiate Model (Table, Classes & Context)						(1) <br>
3. Define Connection String in web.config of solution file			(1) <br>
4. Enable Migration													(1) <br>
	(a)	command: enable-migrations
5. Adding migration													(*) <br>
	(a) command: add-migration [name]
6. Updating database												(*) <br>
	(a) command: update-database
	
[migration -> code to sql]
</div>


