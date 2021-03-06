# State Management Techniques
1. Client-side Techniques
2. Server-side Techniques

## Client-side Techniques
- Whenever we use Client-Side State Management, the state related information will directly get stored on the client-side. That specific information will travel back and communicate with every request generated by the user then afterwards provides responses after server-side communication.

## Server-Side State Management
- Server-Side State Management is different from Client-Side State Management but the operations and working is somewhat the same in functionality. In Server-Side State Management all the information is stored in the user memory. Due to this functionality there is more secure domains at the server side in comparison to Client-Side State Management.

### Client-Side State Management techniques are
1. View State
-  In general we can say it is used for storing user data in ASP.NET, sometimes in ASP.NET applications the user wants to maintain or store their data temporarily after a post-back. In this case VIEW STATE is the most used and preferred way of doing that.
2. Hidden field
-  A hidden field is used for storing small amounts of data on the client side. In most simple words it's just a container of some objects but their result is not rendered on our web browser. It is invisible in the browser.
3. Cookies
-  A set of Cookies is a small text file that is stored in the user's hard drive using the client's browser. Cookies are just used for the sake of the user's identity matching as it only stores information such as sessions id's, some frequent navigation or post-back request objects.
 *  **Persistent Cookie** -  Cookies having an expiration date is called a persistent cookie. This type of cookie reaches their end as their expiration dates comes to an end. In this cookie we set an expiration date.
 *  **Non-Persistent Cookie** - Non-persistent types of cookies aren't stored in the client's hard drive permanently. It maintains user information as long as the user access or uses the services. Its simply the opposite procedure of a persistent cookie.
4. Control State
- Control state is based on the custom control option. For expected results from CONTROL STATE we need to enable the property of view state. As I already described you can manually change those settings.
5. Query Strings
- Query strings are used for some specific purpose. These in a general case are used for holding some value from a different page and move these values to the different page. The information stored in it can be easily navigated to one page to another or to the same page as well.

### Server-Side State Management techniques are
1. Session state
- Session is a very important technique to maintain state. Normally session is used to store information and identity. The server stores information using Sessionid.
- *   **Session Event** has two types 
-   **Session_Start**
- - The Session_start event is raised every time a new user requests without a session ID.
-   **Session_End**
- - The Session_End event is raised when session is ended by a user or a time out using Session end method.
2. Application state
- Application State is a server side management state. It is also called application level state management. In this mainly store user activity in server memory and application event shown in Global.asax file.
- *   **Application_Start** has two types 
- *   **Application_ End** has two types 
- *   **Cache** Cache is stored on server side. It implements Page Caching and data caching. Cache is use to set expiration polices

### Session can be stored in 4 modes
- **InProcMode**
It is a default session mode and a value store in web server memory (IIS). In this the session value stored with server start and it ends when the server is restarted.
- **State Server Mode** 
In this mode session data is stored in separate server.
- **SQL Server Mode**
In this session is stored in the database. It is a secure mode.
- **Custom Mode**
Generally under session data is stored in InProc, Sql Server, State server, etc. If you store session data with other new techniques then provide ASP.NET. 

