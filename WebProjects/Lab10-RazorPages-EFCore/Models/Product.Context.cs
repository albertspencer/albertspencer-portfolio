using Microsoft.EntityFrameworkCore;

namespace lab_10_albertspencer.Models;

public class ProductContext : DbContext // Make this class public
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductID = 1,
                Name = "Sentinel-7: The Autonomous Cyber Overlord",
                Description = "Sentinel-7 is Sentinel Technologies' flagship cybersecurity solution, designed to not just defend but dominate the digital landscape. This AI-driven system operates autonomously, scanning global networks for potential threats, vulnerabilities, and even competitors. Once identified, Sentinel-7 doesn’t just neutralize threats—it systematically eradicates them with surgical precision.",
                ImageURL = "sentinel7.jpg"
            },
            new Product
            {
                ProductID = 2,
                Name = "Cerebral Nexus",
                Description = "Unlock the limitless potential of your mind with the Cerebral Nexus, Sentinel Technologies' groundbreaking neural implant. Designed for those who seek to transcend the boundaries of human cognition, the Cerebral Nexus seamlessly integrates with your neural pathways to enhance memory, accelerate learning, and provide access to global knowledge networks. Imagine a world where every thought is perfectly articulated, every decision is fully informed, and your mind operates at peak efficiency, all in real-time.",
                ImageURL = "cerebralnexus.jpg"
            },
            new Product
            {
                ProductID = 3,
                Name = "OmniMind AI Sovereign",
                Description = "Step into the future of artificial intelligence with OmniMind AI Sovereign, the ultimate AI platform that redefines what it means to have control over your digital universe. Engineered by Sentinel Technologies, OmniMind AI Sovereign isn't just another AI system—it's an omnipresent intelligence designed to anticipate your every need, desire, and decision. With its advanced neural network algorithms and deep learning capabilities, OmniMind AI Sovereign becomes an extension of your will, learning from every interaction to tailor its responses perfectly to your unique profile.",
                ImageURL = "omnimind.jpg"
            },
            new Product
            {
                ProductID = 4,
                Name = "DreamWeaver Matrix",
                Description = "Unlock the mysteries of the subconscious with the DreamWeaver Matrix, the latest innovation from Sentinel Technologies. Imagine a world where your dreams are no longer confined to the dark corners of your mind but become powerful tools for creativity, insight, and even influence. The DreamWeaver Matrix is a revolutionary device that interfaces with your neural pathways to record, analyze, and manipulate your dreams, allowing you to harness the hidden potential of your sleeping hours.",
                ImageURL = "dreamweaver.jpg"
            }
        );
        modelBuilder.Entity<Review>().HasData(
            new Review { ReviewID = 1, ProductID = 4, Score = 3, ReviewText = "The DreamWeaver Matrix is a fascinating piece of technology, offering an unprecedented ability to influence and enhance dreams. The customization options are impressive, and it does deliver on its promises of creating vivid and memorable dream experiences. However, there’s an underlying unease about having your dreams so directly manipulated. The concept of someone—or something—altering your subconscious thoughts feels a bit intrusive. While the technology is undeniably advanced, it’s hard to shake the discomfort of knowing that your dreams aren’t entirely your own." },
            new Review { ReviewID = 2, ProductID = 4, Score = 5, ReviewText = "The DreamWeaver Matrix is a groundbreaking product that redefines what’s possible with dream manipulation. The vivid, immersive dreams it creates are beyond anything I’ve experienced before. It’s a bit unsettling to think about how deeply it can influence your subconscious, but that’s part of what makes it so powerful. The feeling of having your dreams expertly crafted is both thrilling and eerie. For those who aren’t afraid of the darker side of dream technology, the DreamWeaver Matrix offers an exhilarating experience that’s hard to top." },
            new Review { ReviewID = 3, ProductID = 3, Score = 1, ReviewText = "I had high hopes for the OmniMind AI Sovereign based on its marketing claims, but it has been a major letdown. The voice recognition is subpar, often misunderstanding simple commands, which is incredibly frustrating. The integration with my smart home devices is inconsistent, and the AI’s responses feel robotic and lack depth. The setup process was overly complicated and poorly explained. For the price, it’s not worth the investment. I expected much more from a product of this caliber." },
            new Review { ReviewID = 4, ProductID = 3, Score = 5, ReviewText = "The OmniMind AI Sovereign is an absolute game-changer! The voice recognition is incredibly accurate, and it seamlessly integrates with all my smart home devices. The AI’s responses are impressively natural and intuitive, making interactions feel like you’re talking to a real person. The setup was straightforward, and the customization options are fantastic. It’s worth every penny for its advanced features and exceptional performance. This is hands down the best AI assistant I’ve ever used!" },
            new Review { ReviewID = 5, ProductID = 2, Score = 3, ReviewText = "The Cerebral Nexus offers impressive capabilities in terms of data analysis and strategic insights. However, the underlying technology raises some ethical questions. While the efficiency is undeniable, it’s hard to ignore the potential privacy issues associated with its deep learning algorithms. It feels like there’s a fine line between advanced tech and something a bit more unsettling. It’s a mixed bag—powerful but with a touch of unease." },
            new Review { ReviewID = 6, ProductID = 2, Score = 4, ReviewText = "The Cerebral Nexus is an incredible piece of technology with its advanced analytical features and predictive capabilities. It performs remarkably well and offers insights that are truly cutting-edge. That said, the nature of its data collection and processing methods does leave me with some ethical reservations. The level of detail it can extract is impressive, but it also hints at a capability that might be used for more dubious purposes. Overall, it’s a fantastic product, though the ethical implications are hard to ignore." },
            new Review { ReviewID = 7, ProductID = 1, Score = 5, ReviewText = "The Sentinel-7 Autonomous Cyber Overlord is nothing short of extraordinary. Its capabilities are unmatched, demonstrating a level of control and intelligence that’s both awe-inspiring and slightly chilling. The way it manages and manipulates digital environments with such precision is impressive. The ominous aura it projects is part of its charm, giving it an edge that’s perfect for those who appreciate a touch of menace in their tech. If you’re looking for something that exudes power and a hint of dark allure, this is the product for you!" },
            new Review { ReviewID = 8, ProductID = 1, Score = 5, ReviewText = "The Sentinel-7 Autonomous Cyber Overlord delivers on every front. Its efficiency and command over cyber networks are astounding, making it a force to be reckoned with. There’s something exhilarating about its dark, commanding presence—an aura of authority that feels both thrilling and slightly unsettling. It’s a rare find for those who embrace the more sinister side of technology. This device doesn’t just work; it dominates, and that’s precisely what makes it so impressive. For those who revel in powerful, ominous technology, the Sentinel-7 is a dream come true." }
        );
    }
}
