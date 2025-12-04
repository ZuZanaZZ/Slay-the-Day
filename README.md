# Introduction of Slay the Day
To do web application built with ASP.NET Core MVC, C#, Entity Framework Core, and PostgreSQL.
The name "Slay the Day" is meant to be encouraging, motivating the users to conquer the day!
I created this web application because I couldn't find one that meets all my needs while also having my preferred aesthetic. 

# Showcase of functionality
## Navbar
All pages also include quick access navigation bar. You can navigate to the home page by clicking "Slay the Day", or go to "Add Task", see "My Tasks", and "Search" for a specific task.

<img width="505" height="65" alt="image" src="https://github.com/user-attachments/assets/07791f88-0676-448a-b89c-62a0319452a5" />

## Main page
This page has buttons for quick access to "Add task", see "My Tasks", and "Search" for a specific task.

<img width="1859" height="693" alt="image" src="https://github.com/user-attachments/assets/2918fb9e-341a-49a3-838c-5cb65a7c0a41" />

## Add task
You can add tasks on this page. Here you also configure the details of your task, such as whether it's done and its name.

<img width="633" height="456" alt="image" src="https://github.com/user-attachments/assets/2c5822be-a1b4-4294-9f13-146f242b4ebe" />

## See your tasks
All tasks are listed on this page in a table. You can see their completion status, name, and quick actions for each task, which includes editing, seeing the details or deleting the task.

<img width="1858" height="547" alt="image" src="https://github.com/user-attachments/assets/5c8fc455-0a63-4770-ade3-45558e32768f" />

## Edit tasks
If you want to edit the task, for example marking it complete, you can do it here. You can also change the task's name.

<img width="621" height="432" alt="image" src="https://github.com/user-attachments/assets/347175da-a881-4704-9a77-4e9c189efa05" />

## Details
See the complete information about the task. On this page you can also navigate to the edit page for the task.

<img width="475" height="303" alt="image" src="https://github.com/user-attachments/assets/3bec5ba6-a752-4494-b41b-66c57c0d3b9b" />

## Delete a task
If you don't want the task to be shown in the tasks list anymore, you can delete it here.

<img width="736" height="345" alt="image" src="https://github.com/user-attachments/assets/3c082eab-0c06-48b3-aa76-336681ae535f" />

## Search tasks
Here you can search your tasks by their name.

<img width="670" height="378" alt="image" src="https://github.com/user-attachments/assets/565ccdbf-fd22-4095-8260-8f58076d6319" />

<img width="1184" height="335" alt="image" src="https://github.com/user-attachments/assets/a7077a2b-d93a-445e-8fee-dc263a7cfeb6" />

# Future
## Add more parameters to the tasks:
- Priority
	- Low, Moderate, High, Urgent
	- Add the priority for each task,
- Task due date
	- Add the date by which the task is supposed to be completed.
- Tags (with different colors)
	- Add tags to the task, that describe the category it belongs to. For example work/housework.
- Task states
	- To do, Doing (progress values, trackers), and Done
	- Add whether the task is only supposed to be done in the future, is currently being handled or is already done.
- Subtasks
	- If one task requires multiple smaller subtasks to be completed, add them here.
## Views of tasks:
After adding more parameters to the tasks, they can be used for interesting visualisation.
- Additions to list view
	- Priority: Sort the tasks according to highest or lowest priority.
	- Tags: Make sections based on tags that are assigned to the tasks.
- Calendar
	- See a calendar view where your tasks are displayed. Also displays due dates for tasks. 
- Kanban
	- Several columns for To do, Doing, and Done tasks.
- Tree
	- See how subtasks are connected to the main task.
