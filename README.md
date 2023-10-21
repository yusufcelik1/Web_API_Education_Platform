# Web_API_Education_Platform
<h2><b>ACUN MEDYA ACADEMY EDUCATION PLATFORM PROJECT</b></h2>

The main objective of the project is to create an educational platform. This platform allows teachers to upload educational videos and categorize them into different educational categories. Teachers can watch and edit the educational videos assigned to them. Students can view their assigned educational materials and watch the videos, but they cannot make changes to the educational content. Admin users have the authority to manage all aspects of the platform, including user management, educational content editing, and overall system control.
<br>
The project has a five-layer architectural structure: Entities, Presentations, Repositories, Services, and Web API. These layers provide a clear distinction between data management, business logic, and presentation layers. The relationships between database tables are designed to manage user registration for educational access and access to educational content. The project aims to provide an educational platform that allows users to interact with educational materials, manage education, and authorize users based on their roles.
<br>
<h3><b>User Management:</b></h3>
User Roles: Users are divided into three different roles: admin, teacher, and student. These roles determine what operations users can perform on the platform. Admins can access all functions, while teachers can only manage their assigned educational materials, and students can view assigned educational materials.
User Registration and Login: Users can register with their usernames and passwords. After registering, they can log in. User authentication processes are carried out with hashed passwords for security purposes.
Password Reset: Users can reset their passwords. The password reset process includes a secure identity verification procedure.
<br>
<h3><b>Educational Management:</b></h3>
Educational Categories: Educations can be categorized into different categories. Teachers can add their educational materials to these categories.
Educational Videos: Teachers can add educational videos from YouTube in the form of iframes. These videos are used as educational content.
Educational Assignment: Teachers can assign educations to students. Students can access assigned educations and watch the videos.
<br>
<h3><b>Lesson Management:</b></h3>
Lesson Content: Each education may contain multiple lessons. The names of the lessons and their related education information are stored.
Video Watching: Students can watch videos in the lessons. Since videos are integrated with YouTube iframes, the viewing process takes place within the platform.
<br>
<h3><b>Admin Management:</b></h3>
User Management: Admins can manage all users. They can block users or edit user information.
Educational Management: Admins can edit, delete, and add all educations and categories.
Reporting: Admins can track what's happening on the platform and create reports about users, educations, and lessons.
<br>
<h3><b>Security:</b></h3>
User information and passwords are stored securely. Passwords are hashed and salted.
Identity verification and authorization processes are carefully managed.
Necessary measures are taken for API security.
<br>
<h3><b>Database Structure:</b></h3>
The database consists of tables such as Users, Courses, Lessons, and UserCourses. These tables are where data is stored, and a relational database model is used.
<br>
<h3><b>Web API and Layers:</b></h3>
The project has a five-layer architectural structure: Entities, Presentations, Repositories, Services, and Web API. Each layer has a specific function, and these layers facilitate data transmission and business logic management.
The Web API allows clients (e.g., web browsers or mobile applications) to communicate with the platform.

<br><br>
For any inquiries or further information, please feel free to reach out:<br>
Email: <a href = "mailto:yusufcancelik525@gmail.com">yusufcancelik525@gmail.com</a><br>
LinkedIn:<a href = "https://www.linkedin.com/in/yusuf-can-celik/"> Yusuf Can Çelik</a>
