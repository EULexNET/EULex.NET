# EULex.NET

EULex.NET is a cross-platform, open source .NET library to retrieve legal data available on the [EUR-Lex](http://eur-lex.europa.eu) web site.

## Usage

```csharp
    using (var client = new Client (username, password)) {

        var request = new SearchRequest {
            ExpertQuery = "TI ~ privacy",
            SearchLanguage = Language.en,
            PageSize = 10,
            Page = 1
        };

        var response = await client.DoQueryAsync (request);

        var title = response.Results [0].Content.Notice.Expression?.Title [0].Value;

        ...
    }
```

## Disclaimer

The EULex.NET project is not affiliated with or endorsed by the European Commission or the Publications Office of the European Union.

The information on the EUR-Lex web site is subject to a [disclaimer](http://eur-lex.europa.eu/content/legal-notice/legal-notice.html), and a [copyright notice](http://eur-lex.europa.eu/content/legal-notice/legal-notice.html#droits).

If you have questions directly related to the data made available on EUR-Lex, please [contact the EUR-Lex team](http://eur-lex.europa.eu/contact.html)