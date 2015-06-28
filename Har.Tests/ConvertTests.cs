using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Newtonsoft.Json.Linq;

namespace HttpArchive.Tests
{
    public class ConvertTests
    {
        [Fact]
        public void SerializeRoundtrip()
        {
            // ARRANGE
            var expected = Har.Deserialize(TestData.Sample);

            // ACT
            var actual = Har.Deserialize(Har.Serialize(expected));

            // ASSERT
            actual.ShouldBeEquivalentTo(expected);
        }

        [Fact]
        public void PageIdsNotUnique()
        {
            // ARRANGE
            var har = new Har();
            har.Log.Pages.Add(new Page { Id = "page_0" });
            har.Log.Pages.Add(new Page { Id = "page_0" });

            // ACT
            Action act = () => Har.Serialize(har);

            // ASSERT
            act.ShouldThrow<InvalidOperationException>().WithMessage(Resources.PageIdsNotUnique);
        }

        [Fact]
        public void EntryPageRefNotFound()
        {
            // ARRANGE
            var har = new Har();
            har.Log.Entries.Add(new Entry { PageRef = "page_0" });

            // ACT
            Action act = () => Har.Serialize(har);

            // ASSERT
            act.ShouldThrow<InvalidOperationException>().WithMessage(Resources.EntryPageRefNotFound);
        }
    }
}
