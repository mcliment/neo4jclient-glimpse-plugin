Neo4jClient Glimpse Plugin
============================

Description
-----------

This is a simple Glimpse plugin to show query data extracted from Neo4jClient.

Usage
-----

Reference Glimpse.Neo4jClient.dll in your Glimpse-enabled project (it's automatic if you used NuGet) and then register your IGraphClient in the plugin (usually in your global.asax.cs):

```
Glimpse.Neo4jClient.Plugin.RegisterGraphClient(yourGraphClientInstance);
```

Support
-------

Create an issue here on GitHub, send me a message or fork the project and send me a pull request.

Open Source License
-------------------

Neo4jClient Glimpse Plugin is free software distributed under the [Apache License 2.0](http://www.apache.org/licenses/LICENSE-2.0).