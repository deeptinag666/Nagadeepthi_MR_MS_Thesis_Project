import React from 'react'
import { Link } from 'react-router-dom'

import { Helmet } from 'react-helmet'

import NavigationLinks from '../components/navigation-links'
import './home.css'

const Home = (props) => {
  return (
    <div className="home-container">
      <Helmet>
        <title>Ecstatic Short Term Mosquito</title>
        <meta property="og:title" content="Ecstatic Short Term Mosquito" />
      </Helmet>
      <header data-role="Header" className="home-header">
        <div className="home-container1">
          <svg viewBox="0 0 1024 1024" className="home-icon">
            <path d="M44 726h640v84h-640v-84zM684 640h-642q0-98 66-164t160-82 189 0 161 82 66 164zM42 938v-42h642v42q0 18-13 30t-31 12h-554q-18 0-31-12t-13-30zM770 980v-342q0-126-104-226-62-62-182-96l-12-100h212v-174h84v174h214l-72 702q-4 26-23 44t-45 18h-72z"></path>
          </svg>
          <label className="home-text">Restaurant Management System</label>
          <div className="home-nav">
            <Link to="/order-managment" className="home-navlink">
              <NavigationLinks
                InvMgmt="Item Management"
                OrderMgmt="Order Management"
                LabourMgmt="Labour Management"
                rootClassName="rootClassName12"
                className="home-component"
              ></NavigationLinks>
            </Link>
          </div>
        </div>
        <div className="home-btn-group">
          <button className="home-button button">Exit</button>
        </div>
        <div data-role="BurgerMenu" className="home-burger-menu">
          <svg viewBox="0 0 1024 1024" className="home-icon02">
            <path d="M128 554.667h768c23.552 0 42.667-19.115 42.667-42.667s-19.115-42.667-42.667-42.667h-768c-23.552 0-42.667 19.115-42.667 42.667s19.115 42.667 42.667 42.667zM128 298.667h768c23.552 0 42.667-19.115 42.667-42.667s-19.115-42.667-42.667-42.667h-768c-23.552 0-42.667 19.115-42.667 42.667s19.115 42.667 42.667 42.667zM128 810.667h768c23.552 0 42.667-19.115 42.667-42.667s-19.115-42.667-42.667-42.667h-768c-23.552 0-42.667 19.115-42.667 42.667s19.115 42.667 42.667 42.667z"></path>
          </svg>
        </div>
        <div data-role="MobileMenu" className="home-mobile-menu">
          <nav className="home-nav1">
            <div className="home-container2">
              <img
                alt="image"
                src="https://presentation-website-assets.teleporthq.io/logos/logo.png"
                className="home-image"
              />
              <div
                data-role="CloseMobileMenu"
                className="home-close-mobile-menu"
              >
                <svg viewBox="0 0 1024 1024" className="home-icon04">
                  <path d="M810 274l-238 238 238 238-60 60-238-238-238 238-60-60 238-238-238-238 60-60 238 238 238-238z"></path>
                </svg>
              </div>
            </div>
            <NavigationLinks rootClassName="rootClassName14"></NavigationLinks>
          </nav>
          <div>
            <svg viewBox="0 0 950.8571428571428 1024" className="home-icon06">
              <path d="M925.714 233.143c-25.143 36.571-56.571 69.143-92.571 95.429 0.571 8 0.571 16 0.571 24 0 244-185.714 525.143-525.143 525.143-104.571 0-201.714-30.286-283.429-82.857 14.857 1.714 29.143 2.286 44.571 2.286 86.286 0 165.714-29.143 229.143-78.857-81.143-1.714-149.143-54.857-172.571-128 11.429 1.714 22.857 2.857 34.857 2.857 16.571 0 33.143-2.286 48.571-6.286-84.571-17.143-148-91.429-148-181.143v-2.286c24.571 13.714 53.143 22.286 83.429 23.429-49.714-33.143-82.286-89.714-82.286-153.714 0-34.286 9.143-65.714 25.143-93.143 90.857 112 227.429 185.143 380.571 193.143-2.857-13.714-4.571-28-4.571-42.286 0-101.714 82.286-184.571 184.571-184.571 53.143 0 101.143 22.286 134.857 58.286 41.714-8 81.714-23.429 117.143-44.571-13.714 42.857-42.857 78.857-81.143 101.714 37.143-4 73.143-14.286 106.286-28.571z"></path>
            </svg>
            <svg viewBox="0 0 877.7142857142857 1024" className="home-icon08">
              <path d="M585.143 512c0-80.571-65.714-146.286-146.286-146.286s-146.286 65.714-146.286 146.286 65.714 146.286 146.286 146.286 146.286-65.714 146.286-146.286zM664 512c0 124.571-100.571 225.143-225.143 225.143s-225.143-100.571-225.143-225.143 100.571-225.143 225.143-225.143 225.143 100.571 225.143 225.143zM725.714 277.714c0 29.143-23.429 52.571-52.571 52.571s-52.571-23.429-52.571-52.571 23.429-52.571 52.571-52.571 52.571 23.429 52.571 52.571zM438.857 152c-64 0-201.143-5.143-258.857 17.714-20 8-34.857 17.714-50.286 33.143s-25.143 30.286-33.143 50.286c-22.857 57.714-17.714 194.857-17.714 258.857s-5.143 201.143 17.714 258.857c8 20 17.714 34.857 33.143 50.286s30.286 25.143 50.286 33.143c57.714 22.857 194.857 17.714 258.857 17.714s201.143 5.143 258.857-17.714c20-8 34.857-17.714 50.286-33.143s25.143-30.286 33.143-50.286c22.857-57.714 17.714-194.857 17.714-258.857s5.143-201.143-17.714-258.857c-8-20-17.714-34.857-33.143-50.286s-30.286-25.143-50.286-33.143c-57.714-22.857-194.857-17.714-258.857-17.714zM877.714 512c0 60.571 0.571 120.571-2.857 181.143-3.429 70.286-19.429 132.571-70.857 184s-113.714 67.429-184 70.857c-60.571 3.429-120.571 2.857-181.143 2.857s-120.571 0.571-181.143-2.857c-70.286-3.429-132.571-19.429-184-70.857s-67.429-113.714-70.857-184c-3.429-60.571-2.857-120.571-2.857-181.143s-0.571-120.571 2.857-181.143c3.429-70.286 19.429-132.571 70.857-184s113.714-67.429 184-70.857c60.571-3.429 120.571-2.857 181.143-2.857s120.571-0.571 181.143 2.857c70.286 3.429 132.571 19.429 184 70.857s67.429 113.714 70.857 184c3.429 60.571 2.857 120.571 2.857 181.143z"></path>
            </svg>
            <svg viewBox="0 0 602.2582857142856 1024" className="home-icon10">
              <path d="M548 6.857v150.857h-89.714c-70.286 0-83.429 33.714-83.429 82.286v108h167.429l-22.286 169.143h-145.143v433.714h-174.857v-433.714h-145.714v-169.143h145.714v-124.571c0-144.571 88.571-223.429 217.714-223.429 61.714 0 114.857 4.571 130.286 6.857z"></path>
            </svg>
          </div>
          <div className="home-gallery-card">
            <div className="home-container3">
              <div className="home-container4">
                <h2 className="home-text1">Project Title</h2>
                <span className="home-text2">
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit
                </span>
                <span className="home-text3">SHOW MORE</span>
              </div>
            </div>
            <img
              alt="image"
              src="https://images.unsplash.com/photo-1484980972926-edee96e0960d?ixid=Mnw5MTMyMXwwfDF8c2VhcmNofDI0fHxmb29kfGVufDB8fHx8MTYyNjQ0OTIzNQ&amp;ixlib=rb-1.2.1&amp;h=1000"
              className="home-image1"
            />
            <div className="home-gallery-card1">
              <div className="home-container5">
                <div className="home-container6">
                  <h2 className="home-text4">Project Title</h2>
                  <span className="home-text5">
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit
                  </span>
                  <span className="home-text6">SHOW MORE</span>
                </div>
              </div>
              <img
                alt="image"
                src="https://images.unsplash.com/photo-1484980972926-edee96e0960d?ixid=Mnw5MTMyMXwwfDF8c2VhcmNofDI0fHxmb29kfGVufDB8fHx8MTYyNjQ0OTIzNQ&amp;ixlib=rb-1.2.1&amp;h=1000"
                className="home-image2"
              />
            </div>
          </div>
        </div>
      </header>
      <div className="home-container7">
        <div className="home-hero">
          <div className="home-container8">
            <h1 className="home-text7">Simplify Item Management and Orders</h1>
            <span className="home-text8">
              Simplify management of your item inventory and order management
            </span>
            <div className="home-btn-group1">
              <button className="home-button1 button">Get Started</button>
              <button className="home-button2 button">Learn More</button>
            </div>
          </div>
          <img
            alt="image"
            src="https://play.teleporthq.io/static/img/styled-sections/gallery2.jpg"
            className="home-image3"
          />
        </div>
      </div>
    </div>
  )
}

export default Home
