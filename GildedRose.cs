using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                Item item = Items[i];
                if (item.Name != "Aged Brie" && item.Name != "Backstage passes")
                {
                    if (item.Quality > 0)
                    {
                        if (item.Name != "Sulfuras")
                        {
                            item.Quality--;
                        }
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality++;

                        if (item.Name == "Backstage passes")
                        {
                            if (item.SellIn < 11)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality++;
                                }
                            }

                            if (item.SellIn < 6)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality++;
                                }
                            }
                        }
                    }
                }



                if (item.Name != "Sulfuras")
                {
                    item.SellIn--;
                }

                if (item.SellIn < 0) //sell by date passed!
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes")
                        {
                            if (item.Quality > 0)
                            {
                                if (item.Name != "Sulfuras")
                                {
                                    if (item.Name == "Conjured")
                                    {
                                        item.Quality -= 2;
                                    }
                                    item.Quality--; // = item.Quality - 1; //normal item decrement when sellIn is <0
                                }
                            }
                        }
                        else
                        {
                            item.Quality = 0;
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality++;
                        }

                    }
                }
                //normal item with quality over 50

                //conjured degrades twice as fast therefore needs additional decrament here...
                if (item.SellIn >= 0)
                    if (item.Name == "Conjured")
                    {
                        item.Quality--; // = item.Quality - 1;
                    }


                if (item.Quality > 50) //reset quality of normal item to 50 when given an input of 51 or greater
                {
                    item.Quality = 50; //reset to 50
                }

                if (item.Name == "INVALID ITEM")
                {
                    item.Name = "NO SUCH ITEM";
                }

            }
        }
    }
}
