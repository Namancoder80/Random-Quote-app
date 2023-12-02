# Random-Quote-app
# Unity Quote App

## Overview

This Unity project is a simple application that fetches and displays random quotes from a provided API.

## Structure Overview

### Quotes Struct

The `Quotes` struct represents the data structure of a quote, consisting of `content` (the quote text) and `author` (the author of the quote).

### RandomQuote Class

The `RandomQuote` class inherits from `MonoBehaviour` and represents the behavior of the quote display in Unity. It contains references to UI elements (quote text, author text, and a button for the next quote), as well as a string for the API endpoint.

## How to Use

1. **Attach Script:**
   - Attach the `RandomQuote` script to a GameObject in your Unity scene.

2. **Configure API Endpoint:**
   - Set the `QuoteApi` field in the Unity Inspector to the URL of your quote API.

3. **Run the Project:**
   - Run the Unity project, and quotes should be fetched and displayed.

## Code Explanation

- The `Start` method initiates the application by fetching and displaying an initial quote. It also adds an event listener to the `NextQuote` button, allowing the user to fetch a new random quote.

- The `GetRandomQuote` coroutine uses Unity's `UnityWebRequest` to fetch data from the specified URL (`QuoteApi`). It then deserializes the received JSON data into the `Quotes` struct and updates the UI elements (`Quote` and `Author`) with the fetched quote and author.

## Contributions

Contributions are welcome! If you find any issues or want to enhance the project, feel free to open issues and pull requests.

## License

This project is licensed under the [MIT License](LICENSE).

---
