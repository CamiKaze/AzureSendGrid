# SendGrid with Azure

## Overview

This guide demonstrates how to perform common programming tasks with the SendGrid email service on Azure.

## What is the SendGrid Email Service?

SendGrid is a cloud-based email service that provides reliable transactional email delivery, scalability, and real-time analytics along with flexible APIs that make custom integration easy.

Common SendGrid use cases include:

•	Automatically sending receipts or purchase confirmations to customers.

•	Administering distribution lists for sending customers monthly fliers and promotions.

•	Collecting real-time metrics for things like blocked email and customer engagement.

•	Forwarding customer inquiries.

•	Processing incoming emails.

## What is a Resource Group?

Resource groups (RG) in Azure is a new approach to group a collection of assets in logical groups for easy or even automatic provisioning, monitoring, and access control, and for more effective management of their costs. One benefit of using RGs in Azure is grouping related resources that belong to an application together, as they share a unified lifecycle from creation to usage and finally, de-provisioning.

## What is a Blade?

The resource group management blade provides a straightforward way to create and manage resource groups. It also provides a flexible customizable, high-level view of available resource groups in a specific Azure subscription. The user can select what columns to see in this view based on their role and interests and may use filters to zoom in on resource groups specific to a subscription or a location.

## What is a Resource?

A resource is a manageable item that is available through Azure. Virtual machines, storage accounts, web apps, databases, and virtual networks are examples of resources.

## Creating a Resource Group

Azure customers can unlock 25,000 free emails each month. These 25,000 free monthly emails will give you access to advanced reporting and analytics and all APIs (Web, SMTP, Event, Parse, and more). 

To create a Resource Group:

1.	Sign into the Azure portal.

2.	In the Azure portal menu, select “Resource groups”.

3.	Select “Add” to create a Resource Group.

4.	Add the relevant information and select “Review + create”.

5.	The Resource Group is now created in what Azure calls a “Blade”.


## Creating a Resource
1.	In the blade that holds the NotificationsGroup, select “Add”.

2.	You will be redirected to a Marketplace where you can search for various resources. This tutorial focuses on “SendGrid”. Search for “SendGrid” and select “Create”.

3.	Populate the relevant fields and select “Review + Create”.

The resource will be deployed in the NotificationsGroup resource group.

4.	To send an email using SendGrid, you must supply an API key. To find your SendGrid API Key, navigate to the newly created resource (EmailService) and select “Manage”.

5.	You will be redirected to your SendGrid dashboard where you must generate an API Key.

Given the options in the project setup, Select Web API, a programming language of your choice (C# in my case), supply a name for your API key, and select “Create Key”.

In this tutorial, you created a Resource Group, a Resource, and an email service like SendGrid, using Azure.

## Next Steps

Now that you have learned the basics of the SendGrid Email service, follow these links to learn more.

•	SendGrid C# library repo: sendgrid-csharp

•	SendGrid API documentation: https://sendgrid.com/docs


