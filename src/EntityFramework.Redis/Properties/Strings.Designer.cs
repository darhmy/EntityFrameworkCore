// <auto-generated />
namespace Microsoft.Data.Entity.Redis
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
	using JetBrains.Annotations;

    public static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("EntityFramework.Redis.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// The string argument '{argumentName}' cannot be empty.
        /// </summary>
        public static string ArgumentIsEmpty([CanBeNull] object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsEmpty", "argumentName"), argumentName);
        }

        /// <summary>
        /// The bytes {0} could not be interpreted as a UTF-8 string.
        /// </summary>
        public static string InvalidDatabaseValue([CanBeNull] object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidDatabaseValue"), p0);
        }

        /// <summary>
        /// The value provided for argument '{argumentName}' must be a valid value of enum type '{enumType}'.
        /// </summary>
        public static string InvalidEnumValue([CanBeNull] object argumentName, [CanBeNull] object enumType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidEnumValue", "argumentName", "enumType"), argumentName, enumType);
        }

        /// <summary>
        /// Primary Key value for Entity '{0}', Property '{1}' cannot be null.
        /// </summary>
        public static string InvalidPrimaryKeyValue([CanBeNull] object p0, [CanBeNull] object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidPrimaryKeyValue"), p0, p1);
        }

        /// <summary>
        /// Cannot decode property of name '{0}' of type '{1}' on EntityType '{2}'.
        /// </summary>
        public static string UnableToDecodeProperty([CanBeNull] object p0, [CanBeNull] object p1, [CanBeNull] object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnableToDecodeProperty"), p0, p1, p2);
        }

        /// <summary>
        /// Cannot update entity of type '{0}' with key '{1}' because the key does not exist in the Primary Key Index for that entity.
        /// </summary>
        public static string UnableToUpdate([CanBeNull] object p0, [CanBeNull] object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnableToUpdate"), p0, p1);
        }

        /// <summary>
        /// Redis-specific methods can only be used when the context is using a Redis data store.
        /// </summary>
        public static string RedisNotInUse
        {
            get { return GetString("RedisNotInUse"); }
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
