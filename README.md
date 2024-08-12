# SignalRSwaggerGen Attribute Example
Small example of using the SignalRSwaggerGen attributes for methods. Since I have little experience with attributes in general and there is little documentation on SignalRSwaggerGen, using these attributes led to a some headaches. I hope this helps someone.

## Background
For a .NET project utilizing SignalR, some of the SignalR endpoints/methods were integrated into the Swagger documentation of the API, using the [SignalRSwaggerGen library](https://github.com/essencebit/SignalRSwaggerGen/wiki) by @essencebit and the attributes it provides.

## My problem
When I tried to use SignalRReturn and SignalRParam, I got [error CS0592](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0592?f1url=%3FappId%3Droslyn%26k%3Dk(CS0592)), but I had a hard time understanding what I had done wrong when applying the attributes.

## Solution
**See the code snippet**.

After some trial and error and a lot of pointless googling, I found the right use.

I hope this saves someone some time and helps to understand attributes better!
