![StringReverse](http://i.imgur.com/lKo0eYy.png)
# StringReverse

StringReverse is a unicode aware/compatible string reverse extension.

# Supported Platforms

* .NET 4.5 (We are a Profile78 Portable Class Library)
* Mono
* Xamarin.iOS
* Xamarin.Android
* Xamarin.Mac

# Installation
Installation is done via NuGet:

	Install-Package StringReverse

# Usage

	using StringReverse;
    
    var input = "foo\uD834\uDF06\u0303\u035C\u035D\u035Ebar";
    var output = input.Reverse();   // "rab\uD834\uDF06\u0303\u035C\u035D\u035Eoof"

## With thanks to
* The icon "<a href="http://thenounproject.com/term/reverse/6487/" target="_blank">Reverse</a>" designed by <a href="http://thenounproject.com/mateozlatar/" target="_blank">Mateo Zlatar</a> from The Noun Project.
