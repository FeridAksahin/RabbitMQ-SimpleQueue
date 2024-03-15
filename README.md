# RabbitMQ-SimpleQueue


This project contains a sample implementation to demonstrate the basic functionality of the RabbitMQ message queue system. It consists of a publisher, which broadcasts product notifications, and a consumer, which receives these notifications. Communication between these two components is facilitated using the RabbitMQ message queue.

### Features

- The ProductNotificationProducer class is used to send product notifications to the RabbitMQ message queue.
- The ProductNotificationConsumer class is used to receive product notifications from the RabbitMQ message queue.
- Both classes are created using the RabbitMQ.Client library.
- It connects to a RabbitMQ server hosted on CloudAMQP for message queue operations.

### Usage

- You can use the ProductNotificationProducer class to send product notifications to the RabbitMQ message queue.
- You can use the ProductNotificationConsumer class to receive product notifications from the RabbitMQ message queue.
- A RabbitMQ server is required for the project to work. You can provide this server using CloudAMQP or your own local RabbitMQ server.

This sample project is aimed at developers who want to understand and implement the basic concepts of RabbitMQ. The project has a simple and understandable structure, making it an ideal starting point for those who want to learn RabbitMQ usage.
