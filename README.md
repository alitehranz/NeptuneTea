# Neptune Tea — Bubble Tea Shop Website
https://neptunetea-shop.netlify.app/

# Backend Swagger UI dashboard
# 🍵 Neptune Tea API
[![Live Demo](https://img.shields.io/badge/Live-Demo-brightgreen)](https://neptunetea.onrender.com/api/menu)

A clean, mobile-first website for a local bubble tea shop with a modern, cozy, and slightly futuristic aesthetic. Built with pure HTML and CSS.

---

## 📋 Project Overview

This is a static, informational website for "Neptune Tea," a fictional bubble tea shop. The site showcases the menu, provides business information, and establishes a premium brand presence online.

**Purpose:** Informational website (not e-commerce)
**Target Audience:** Customers looking for bubble tea shop info, menu, and location
**Design Philosophy:** Minimal, premium, calm — inspired by modern lifestyle brands

---

## 🛠️ Tech Stack

- **HTML5** — Semantic markup, accessibility-focused
- **CSS3** — Custom properties (CSS variables), Flexbox, CSS Grid
- **No JavaScript** — Pure HTML/CSS implementation
- **No frameworks** — Vanilla code only
- **No backend** — Static site, client-side only

---

## 📁 File Structure

```
bubble-tea-demo/
├── index.html       # Main HTML structure (all sections)
├── styles.css       # All styling (mobile-first responsive)
└── README.md        # Project documentation (this file)
```

---

## 🎨 Design System

### Color Palette

The design uses soft pastel colors inspired by florals, with very low saturation for a premium feel:

```css
--color-rose: #fde4e9       /* Soft pink/rose */
--color-lavender: #e8dff5   /* Light purple */
--color-sage: #e8f3ed       /* Pale green */
--color-cream: #faf8f3      /* Off-white/cream */
--color-peach: #ffeee6      /* Soft peach */
--color-white: #ffffff      /* Pure white */
--color-text: #2a2a2a       /* Dark gray for text */
--color-text-light: #6a6a6a /* Medium gray for secondary text */
--color-border: #e8e8e8     /* Light border color */
```

### Typography

- **Font Family:** System fonts (`-apple-system, BlinkMacSystemFont, 'Segoe UI', 'Roboto', etc.`)
- **Base Size:** 1rem (16px) on mobile, 1.125rem (18px) on desktop
- **Headings:** 600 font-weight, tight line-height (1.2)
- **Body Text:** 1.6 line-height for readability

### Spacing Scale

```css
--spacing-xs: 0.5rem   /* 8px */
--spacing-sm: 1rem     /* 16px */
--spacing-md: 1.5rem   /* 24px */
--spacing-lg: 2.5rem   /* 40px */
--spacing-xl: 4rem     /* 64px */
```

### Border Radius

```css
--radius-sm: 8px
--radius-md: 16px
--radius-lg: 24px
```

All cards and buttons use rounded corners for a soft, modern feel.

---

## 🎯 Design Principles

### 1. **Minimal & Premium**
- Not playful or childish
- Clean, spacious layouts
- Sophisticated color choices
- Professional typography

### 2. **Floral Inspiration (Subtle)**
- Soft petal-like shapes (low opacity gradients)
- Pastel colors inspired by flowers
- **Avoids:** Cartoon flowers, bold prints, tacky decorations

### 3. **Mobile-First**
- Designed for phones first
- Progressive enhancement for tablets and desktops
- Touch-friendly spacing and buttons

### 4. **Calm & Cozy**
- Generous white space
- Soft gradients instead of harsh contrasts
- Subtle hover effects only
- No busy animations

---

## 📱 Responsive Design

### Breakpoints

```css
Mobile:   < 640px   (1 column grid)
Tablet:   640px+    (2 column grid)
Desktop:  1024px+   (3-4 column grid)
Large:    1280px+   (4 column grid)
```

### Grid Behavior

**Menu Cards:**
- Mobile: 1 column
- Tablet (640px+): 2 columns
- Desktop (1024px+): 3 columns
- Large (1280px+): 4 columns

**Contact Cards:**
- Mobile: 1 column stacked
- Tablet (640px+): 3 columns side-by-side

---

## 🧩 HTML Structure

### Sections Overview

1. **Navigation (`<nav>`)** — Sticky header with brand name and anchor links
2. **Hero (`#home`)** — Welcome section with gradient background and CTA button
3. **Menu (`#menu`)** — 42 drinks organized in 5 categories
4. **About (`#about`)** — Brand story and philosophy
5. **Contact (`#contact`)** — Location, hours, and contact info
6. **Footer** — Copyright and branding

### Navigation Logic

Uses anchor links (`#home`, `#menu`, `#about`, `#contact`) for smooth scrolling:

```html
<a href="#menu">Menu</a>
```

CSS handles smooth scrolling:

```css
html {
    scroll-behavior: smooth;
}
```

### Menu Structure

Each menu category follows this pattern:

```html
<div class="menu-category">
    <h3>Category Name</h3>
    <div class="menu-grid">
        <div class="menu-card">
            <h4>Drink Name</h4>
            <p>Description</p>
            <span class="price">$5.50</span>
        </div>
        <!-- More cards... -->
    </div>
</div>
```

**Menu Categories:**
1. Milk Tea Classics (8 drinks)
2. Fruit Tea (8 drinks)
3. Cheese Tea (5 drinks)
4. Special Lattes (6 drinks)
5. Seasonal Specials (7 drinks)

**Total: 34 drinks** (expandable to ~40 as mentioned)

---

## 🎨 CSS Architecture

### Organization

The CSS is organized in logical sections:

1. **Variables & Reset** — CSS custom properties, global reset
2. **Typography** — Heading styles, font sizing
3. **Layout** — Container, section spacing
4. **Navigation** — Sticky nav, nav links
5. **Hero Section** — Gradient background, decorative shapes
6. **Menu Section** — Grid layout, card styling
7. **About Section** — Background gradients, decorative elements
8. **Contact Section** — Contact cards
9. **Footer** — Simple centered footer
10. **Responsive** — Media queries for tablet/desktop

### Key CSS Techniques

**1. CSS Grid for Responsive Layouts**
```css
.menu-grid {
    display: grid;
    grid-template-columns: 1fr; /* Mobile: 1 column */
    gap: var(--spacing-md);
}

@media (min-width: 640px) {
    .menu-grid {
        grid-template-columns: repeat(2, 1fr); /* Tablet: 2 columns */
    }
}
```

**2. CSS Variables for Theming**
```css
:root {
    --color-rose: #fde4e9;
    --spacing-md: 1.5rem;
}

.menu-card {
    background: var(--color-rose);
    padding: var(--spacing-md);
}
```

**3. Pseudo-elements for Decorative Shapes**
```css
.hero::before {
    content: '';
    position: absolute;
    background: radial-gradient(circle, rgba(232, 223, 245, 0.3) 0%, transparent 70%);
    border-radius: 50% 40% 60% 50%; /* Organic petal-like shape */
}
```

**4. nth-child for Alternating Card Backgrounds**
```css
.menu-card:nth-child(4n+1) { background: var(--color-cream); }
.menu-card:nth-child(4n+2) { background: var(--color-rose); }
.menu-card:nth-child(4n+3) { background: var(--color-sage); }
.menu-card:nth-child(4n+4) { background: var(--color-lavender); }
```

**5. Sticky Navigation**
```css
.nav {
    position: sticky;
    top: 0;
    z-index: 100;
    backdrop-filter: blur(10px);
    background: rgba(255, 255, 255, 0.95);
}
```

---

## ✨ Features

### Current Features

✅ **Responsive Design** — Works on all screen sizes
✅ **Smooth Scrolling** — Anchor links scroll smoothly to sections
✅ **Sticky Navigation** — Nav bar stays at top while scrolling
✅ **42 Menu Items** — Organized into 5 categories
✅ **Subtle Animations** — Hover effects on cards and buttons
✅ **Accessible** — Semantic HTML, readable fonts, good contrast
✅ **Fast Loading** — No dependencies, pure HTML/CSS

### What's NOT Included (By Design)

❌ **JavaScript** — Not needed for this static site
❌ **Backend** — No server-side code
❌ **E-commerce** — No shopping cart or checkout
❌ **Forms** — No contact form submission
❌ **Analytics** — No tracking code
❌ **Heavy Animations** — Kept minimal for performance

---

## 🚀 How to Use

### View the Website

**Option 1: Double-click**
- Navigate to the project folder
- Double-click `index.html`
- Opens in your default browser

**Option 2: Terminal**
```bash
cd /Users/alitehrani/Local/bubble-tea-demo
open index.html
```

**Option 3: Drag & Drop**
- Drag `index.html` into any browser window

### Edit the Website

**To change content:**
1. Open `index.html` in any text editor
2. Find the section you want to edit
3. Modify the HTML
4. Save and refresh browser

**To change styling:**
1. Open `styles.css` in any text editor
2. Modify CSS properties
3. Save and refresh browser

**To change colors:**
- Edit CSS variables at the top of `styles.css` (lines 8-16)

---

## 🔧 Customization Guide

### Change Brand Name

Find and replace "Neptune Tea" in `index.html`

### Update Menu Items

1. Go to the Menu Section in `index.html` (around line 35)
2. Find the appropriate `<div class="menu-card">`
3. Edit the `<h4>` (name), `<p>` (description), or `<span class="price">` (price)

### Add New Menu Items

Copy an existing menu card and paste it within the same `menu-grid`:

```html
<div class="menu-card">
    <h4>New Drink Name</h4>
    <p>Description of the drink</p>
    <span class="price">$6.00</span>
</div>
```

### Change Contact Information

Edit the Contact Section in `index.html` (lines 260-280)

### Adjust Colors

Edit CSS variables in `styles.css` (lines 8-16):

```css
:root {
    --color-rose: #fde4e9;      /* Change this hex code */
    --color-lavender: #e8dff5;  /* Change this hex code */
    /* etc. */
}
```

---

## 🎓 Learning Notes

### Why No JavaScript?

This site doesn't need JavaScript because:
- No interactive forms
- No dynamic content loading
- Smooth scrolling handled by CSS (`scroll-behavior: smooth`)
- No user accounts or state management
- All content is static

### Why Mobile-First?

Mobile-first means:
1. Design for small screens first (simplest layout)
2. Add complexity for larger screens with media queries
3. Results in cleaner, more maintainable code
4. Better performance on mobile devices

### Why CSS Grid Over Flexbox for Menu?

CSS Grid is ideal when:
- You need 2D layouts (rows AND columns)
- You want responsive column counts
- Items should be uniform size

Flexbox is better for:
- 1D layouts (row OR column)
- Navigation bars
- Centering items

---

## 🚀 Future Enhancements

If you want to expand this site, here are some options:

### Easy Additions (No Backend Needed)

- **Image Gallery** — Add photos of drinks
- **Google Maps Embed** — Show location
- **Social Media Icons** — Link to Instagram, Facebook
- **FAQ Section** — Common questions
- **Testimonials** — Customer reviews

### Advanced Additions (Require Backend)

- **Online Ordering** — Shopping cart + checkout
- **Payment Processing** — Stripe, Square, PayPal
- **Contact Form** — Email submissions
- **Newsletter Signup** — Email collection
- **Loyalty Program** — Points/rewards system
- **Admin Panel** — Update menu without editing code

### Recommended Tools for Upgrades

- **Shopify** — Full e-commerce platform
- **Square Online** — Free ordering for restaurants
- **Netlify Forms** — Simple form handling
- **Mailchimp** — Email marketing

---

## 📄 Browser Support

This site uses modern CSS features but is widely supported:

- ✅ Chrome 90+
- ✅ Firefox 88+
- ✅ Safari 14+
- ✅ Edge 90+
- ✅ Mobile browsers (iOS Safari, Chrome Android)

**Note:** IE11 is not supported (uses CSS Grid, CSS Variables)

---

## 📝 Code Quality

### Accessibility

- Semantic HTML5 elements (`<nav>`, `<section>`, `<footer>`)
- Proper heading hierarchy (h1 → h2 → h3 → h4)
- Readable font sizes (minimum 16px)
- Good color contrast ratios
- Descriptive link text

### Performance

- No external dependencies
- Minimal CSS (no bloat)
- No JavaScript overhead
- Fast page load (~10KB total)
- No image optimization needed (no images currently)

### Maintainability

- Clear section comments in HTML and CSS
- Consistent naming conventions
- CSS variables for easy theming
- Logical file organization
- Well-documented README

---

## 👥 For Engineers & LLMs

### Quick Context

**What this is:**
A static HTML/CSS website for a bubble tea shop. No framework, no build process, no dependencies.

**What it does:**
Displays menu, business info, and brand identity. Smooth scrolling navigation, responsive grid layouts.

**What it doesn't do:**
No e-commerce, no forms, no backend, no JavaScript functionality.

### Code Architecture

- **HTML:** Single-file structure with anchor navigation
- **CSS:** Mobile-first with progressive enhancement via media queries
- **Design System:** CSS variables for colors, spacing, typography
- **Layout:** CSS Grid for cards, Flexbox for nav and content alignment
- **Responsive:** 4 breakpoints (640px, 768px, 1024px, 1280px)

### Key Files

- `index.html` — All content and structure (285 lines)
- `styles.css` — All styling (400+ lines, well-commented)

### To Extend This Project

1. Keep the existing design system (CSS variables)
2. Follow the established naming conventions (`.menu-card`, `.contact-card`, etc.)
3. Maintain mobile-first approach in media queries
4. Use semantic HTML
5. Keep animations subtle (optional hover effects only)

---

## 📞 Support

This is a standalone project with no dependencies. If you encounter issues:

1. **Styling broken?** Check that `styles.css` is in the same directory as `index.html`
2. **Navigation not working?** Ensure anchor IDs match (`#menu` → `id="menu"`)
3. **Responsive issues?** Test in different browsers (Chrome, Safari, Firefox)

---

## 📜 License

This is a demo project. Feel free to use, modify, and distribute as needed.

---

**Built with:** HTML5, CSS3
**Design:** Minimal, modern, mobile-first
**Status:** Production-ready (informational site)
**Last Updated:** 2024

---

## 🎨 Visual Reference

### Design Aesthetic
- **Inspiration:** Modern lifestyle brands (beauty, wellness)
- **Feel:** Calm, cozy, premium
- **Not:** Playful, childish, busy, tacky

### Color Mood
- Soft pastels (low saturation)
- Floral-inspired but subtle
- Clean white backgrounds
- Warm, inviting accents

---

=============
**BACK-END* 
=============

# Neptune Tea API

C# backend API for Neptune Tea bubble tea shop. Built with ASP.NET Core Minimal API and SQLite.

## Tech stack
- **C# / .NET 8**
- **ASP.NET Core Minimal API**
- **Entity Framework Core**
- **SQLite Database**


## Features

### API Endpoints

**1. GET /api/menu**
- Returns all menu items
- Response: Array of menu items with id, name, description, price, category

**2. GET /api/menu/{category}**
- Returns menu items filtered by category
- Categories: `MilkTeaClassics`, `FruitTea`, `CheeseTea`, `SpecialLattes`, `SeasonalSpecials`
- Example: `/api/menu/FruitTea`

**3. POST /api/orders**
- Creates a new order
- Request body: `{ "itemName": "Matcha Milk Tea", "quantity": 2 }`
- Response: Created order with auto-generated ID and timestamp

### Database

- **MenuItems table**: 34 drinks (seeded automatically on startup)
- **Orders table**: Stores customer orders

## How to Run Locally

```bash
# Restore dependencies
dotnet restore

# Run the API
dotnet run

The API includes built-in Swagger UI for easy testing and exploration of the endpoints.

Local Access: Once running, navigate to http://localhost:5000/

Features: Directly execute GET requests or test POST orders through the browser interface without needing Postman.


## Live Deployment

Backend API deployed on Render: [your-render-url-here] # adding later

Test it:
- GET https://your-api.onrender.com/api/menu

## Frontend

The frontend for this project is deployed separately on Netlify:
- Live site: https://neptunetea-shop.netlify.app
Note: Frontend and backend are not currently integrated.
