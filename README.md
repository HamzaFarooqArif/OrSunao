# OrSunao Messenger
![OrSunao-main-img](https://i.imgur.com/pUAsdsN.png)

Instant Messaging App used to share text and images in chat groups as well. Some of its features are.
* You can direct send messages and images to friends instantly.
* You can chat in groups.
* Admin can see the activities and control user activity.
## Setup
This application work on **LAN**. All of the users have to be on same network.
### Server
* (skip this if client is same machine as server) go to `App.config` and you will find `http://localhost:3255/Service1.svc` under `applicationSettings`. Change `localhost` to valid ip address E.g. `http://192.168.8.1:3255/Service1.svc`
* Start the `Server` application.
### Client
* Start the `Client` application.
* Try to register as an **Admin**
* You will receive a confirmation message.
