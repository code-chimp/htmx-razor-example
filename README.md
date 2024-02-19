# Contacts App (ASP.NET Razor Pages)

A .NET Razor Pages application made in the spirit of the [official Flask example][htmx-proj] application 
that accompanies the book [Hypermedia Systems][htmx-book]. You can use this application as a starting point
to follow along with the book starting at [Chapter 05](https://hypermedia.systems/htmx-in-action/).

## Note

- I deliberately removed jQuery and jQuery-Validate to show a "chunky" Web 1.0 app with as little client-side
    JavaScript as possible. This is also more in line with the official [Flask][flask] [application][htmx-proj] used in 
    the [book][htmx-book].
- The data service is rudimentary as that is not the point of the book, and by using a JSON file
    as the data store, it is easy to follow along without setting up a database and worrying about additional dependencies.
- I will win no awards for design in my lifetime and I am okay with this.


[htmx]: https://htmx.org "High power tools for HTML"
[htmx-book]: https://hypermedia.systems/ "Hypermedia Systems Book"
[flask]: https://flask.palletsprojects.com/ "Flask - A minimal web framework for Python"
[htmx-proj]: https://github.com/bigskysoftware/contact-app "Contact App - official"

