using XmlnsPrefixAttribute = Microsoft.Maui.Controls.XmlnsPrefixAttribute;

// Custom controls use their own schema; the standard MAUI schema is protected.
[assembly: XmlnsDefinition("http://autocar.com/schemas/xaml", "Maui.Auto.Car")]

// Recommended prefix for the custom schema.
[assembly: XmlnsPrefix("http://autocar.com/schemas/xaml", "car")]
