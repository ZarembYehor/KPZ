using Task3_4;

var divElement = new LightElementNode("div", "block", "normal", new List<string> { "container" });
var spanElement = new LightElementNode("span", "inline", "self-closing", new List<string> { "text-element" });

// Додаємо слухачів подій
var listener = new SimpleEventListener();
divElement.AddEventListener("click", listener);
spanElement.AddEventListener("mouseover", listener);

// Виводимо HTML
divElement.PrintOuterHTML();
spanElement.PrintOuterHTML();

// Викликаємо події
divElement.TriggerEvent("click");
spanElement.TriggerEvent("mouseover");

var networkImageElement = new ImageElement("https://via.placeholder.com/150", new NetworkImageLoadingStrategy());
var fileImageElement = new ImageElement("local_image.png", new FileImageLoadingStrategy());

// Завантажуємо та відображаємо зображення
await networkImageElement.LoadAndDisplayImage();
await fileImageElement.LoadAndDisplayImage();