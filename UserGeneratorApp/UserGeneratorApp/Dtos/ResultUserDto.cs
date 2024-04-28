using System.Text.Json.Serialization;

namespace UserGeneratorApp.Dtos
{
    public class ResultUserDto
    {
        public record Coordinates(
            [property: JsonPropertyName("latitude")] string latitude,
            [property: JsonPropertyName("longitude")] string longitude
        );

        public record Dob(
            [property: JsonPropertyName("date")] DateTime date,
            [property: JsonPropertyName("age")] int age
        );

        public record Id(
            [property: JsonPropertyName("name")] string name,
            [property: JsonPropertyName("value")] object value
        );

        public record Info(
            [property: JsonPropertyName("seed")] string seed,
            [property: JsonPropertyName("results")] int results,
            [property: JsonPropertyName("page")] int page,
            [property: JsonPropertyName("version")] string version
        );

        public record Location(
            [property: JsonPropertyName("street")] Street street,
            [property: JsonPropertyName("city")] string city,
            [property: JsonPropertyName("state")] string state,
            [property: JsonPropertyName("country")] string country,
            //[property: JsonPropertyName("postcode")] int postcode,
            [property: JsonPropertyName("coordinates")] Coordinates coordinates,
            [property: JsonPropertyName("timezone")] Timezone timezone
        );

        public record Login(
            [property: JsonPropertyName("uuid")] string uuid,
            [property: JsonPropertyName("username")] string username,
            [property: JsonPropertyName("password")] string password,
            [property: JsonPropertyName("salt")] string salt,
            [property: JsonPropertyName("md5")] string md5,
            [property: JsonPropertyName("sha1")] string sha1,
            [property: JsonPropertyName("sha256")] string sha256
        );

        public record Name(
            [property: JsonPropertyName("title")] string title,
            [property: JsonPropertyName("first")] string first,
            [property: JsonPropertyName("last")] string last
        );

        public record Picture(
            [property: JsonPropertyName("large")] string large,
            [property: JsonPropertyName("medium")] string medium,
            [property: JsonPropertyName("thumbnail")] string thumbnail
        );

        public record Registered(
            [property: JsonPropertyName("date")] DateTime date,
            [property: JsonPropertyName("age")] int age
        );

        public record Result(
            [property: JsonPropertyName("gender")] string gender,
            [property: JsonPropertyName("name")] Name name,
            [property: JsonPropertyName("location")] Location location,
            [property: JsonPropertyName("email")] string email,
            [property: JsonPropertyName("login")] Login login,
            [property: JsonPropertyName("dob")] Dob dob,
            [property: JsonPropertyName("registered")] Registered registered,
            [property: JsonPropertyName("phone")] string phone,
            [property: JsonPropertyName("cell")] string cell,
            [property: JsonPropertyName("id")] Id id,
            [property: JsonPropertyName("picture")] Picture picture,
            [property: JsonPropertyName("nat")] string nat
        );

        public record Root(
            [property: JsonPropertyName("results")] IReadOnlyList<Result> results,
            [property: JsonPropertyName("info")] Info info
        );

        public record Street(
            [property: JsonPropertyName("number")] int number,
            [property: JsonPropertyName("name")] string name
        );

        public record Timezone(
            [property: JsonPropertyName("offset")] string offset,
            [property: JsonPropertyName("description")] string description
        );




    }
}
