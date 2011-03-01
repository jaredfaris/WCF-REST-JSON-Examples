WcfRestJsonExamples - A WCF service demonstrating how to use JSON and REST.
=======

# LICENSE
Apache 2.0 -- see LICENSE

# SETUP
Open the .sln file in VS2010.  There are two very basic WCF console services in the solution:
* WcfService - Listens on port 80 and is intended to demonstrate accessing a service on the same host 
* WcfJsonpService - Listens on port 8080 to demonstrate using JSONP to access a service on a remote host

Open the WebClient/index.html file in your browser.  You may need to set this up as a local IIS virtual directory so that it's http://localhost and not file://localhost.

Click some buttons and see what happens.

Enjoy!
