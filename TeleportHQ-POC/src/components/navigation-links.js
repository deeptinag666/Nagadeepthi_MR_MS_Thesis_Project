import React from 'react'

import PropTypes from 'prop-types'

import './navigation-links.css'

const NavigationLinks = (props) => {
  return (
    <nav className={`navigation-links-nav ${props.rootClassName} `}>
      <span className="navigation-links-text">{props.OrderMgmt}</span>
      <span className="navigation-links-text1">{props.LabourMgmt}</span>
      <span className="navigation-links-text2">{props.InvMgmt}</span>
    </nav>
  )
}

NavigationLinks.defaultProps = {
  OrderMgmt: 'Order Management',
  rootClassName: '',
  InvMgmt: 'Inventory Management',
  LabourMgmt: 'Labour Management',
}

NavigationLinks.propTypes = {
  OrderMgmt: PropTypes.string,
  rootClassName: PropTypes.string,
  InvMgmt: PropTypes.string,
  LabourMgmt: PropTypes.string,
}

export default NavigationLinks
