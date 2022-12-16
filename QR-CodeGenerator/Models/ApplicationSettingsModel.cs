using System.Runtime.Serialization;

namespace QR_CodeGenerator.Models;

/// <summary>
/// ApplicationSettingsModel
/// </summary>
[DataContract(Name = "ApplicationSettingsModel", Namespace = "Models", IsReference = true)]
public class ApplicationSettingsModel
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    [DataMember(Name = "Id",Order = 1)]
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the modified date.
    /// </summary>
    /// <value>
    /// The modified date.
    /// </value>
    [DataMember(Name = "ModifiedDate", Order = 2)]
    public DateTime ModifiedDate { get; set; }

    /// <summary>
    /// Gets or sets the length of the text.
    /// </summary>
    /// <value>
    /// The length of the text.
    /// </value>
    [DataMember(Name = "TextLength", Order = 3)]
    public int TextLength { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether [generate qr image].
    /// </summary>
    /// <value>
    ///   <c>true</c> if [generate qr image]; otherwise, <c>false</c>.
    /// </value>
    [DataMember(Name = "GenerateQRImage", Order = 4)]
    public bool GenerateQRImage { get; set; }

    /// <summary>
    /// Gets or sets the random type of the text.
    /// </summary>
    /// <value>
    /// The random type of the text.
    /// </value>
    [DataMember(Name = "RandomTextType", Order = 5, IsRequired = true)]
    public RandomDataType RandomTextType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [DataContract(Name = "RandomDataType",Namespace = "Models.RandomDataType", IsReference = true)]
    public enum RandomDataType : int
    {
        /// <summary>
        /// The numeric
        /// </summary>
        Numeric,
        /// <summary>
        /// The alphanumeric
        /// </summary>
        Alphanumeric,
        /// <summary>
        /// The password
        /// </summary>
        Password,
        /// <summary>
        /// The hexadecimal
        /// </summary>
        Hexadecimal
    }
}