███╗   ███╗██╗██╗   ██╗ █████╗ ██╗  ██╗ ██████╗ 
████╗ ████║██║╚██╗ ██╔╝██╔══██╗██║ ██╔╝██╔═══██╗
██╔████╔██║██║ ╚████╔╝ ███████║█████╔╝ ██║   ██║
██║╚██╔╝██║██║  ╚██╔╝  ██╔══██║██╔═██╗ ██║   ██║
██║ ╚═╝ ██║██║   ██║   ██║  ██║██║  ██╗╚██████╔╝
╚═╝     ╚═╝╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
▀▄▀▄ Arisu Miyako - http://blog.miyako.pro  ▄▀▄▀
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓

Back in the day long before C# and even DotNet
there used to be a traditional past time in
Visual Basic amongst crackers. We use to write
chip-tune music, make cool animated scenes
and custom forms with transparency. Sadly this
tradion is forgotten more and more every year.
Places like http://keygenmusic.org are lacking
in new content. Never fear however, for the
tradion can be brought back.

In spirit of the old, we (you the reader, and
myself) have decided to have a throwback to
the past with a good ol' chip-tune. After
spending a while trying to figure out how to
play one in today's world of dotnet we probably
came across Un4seen Bass24. A very powerful
library for playing music. Unfortunately
it isn't very compatible with dotnet and is
also very bloated. Therefore we have chosen a
more native approach. Directly importing
functions from a native, unmanaged DLL called
ufmod. This wonderfully small library does
just what we want and only what we want,
plays a .xm chip-tune. Life is good, but...

What cracker wants to ship their warez with
a dll and a loose file? NONE of course.
If you tried to embedded your song and the DLL
as a resouce you'll have found 2 things.
First, the song embeds and plays fine.
Secondly, the program crashes when trying to
load the native DLL as a resource. Quite
a shame really. Hope is not to be lost though.

This here project is a template for your
nostalgic warez needs. It contains a fine
example of how to embed native DLLs as
resources, move a borderless form, and fade
the color of a label. Just like the old VB6
days, except in C# dotnet 4.6.1.