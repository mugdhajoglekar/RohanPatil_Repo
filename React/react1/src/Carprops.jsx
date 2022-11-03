// 2. Modify the above component to pass these values as props

import React from 'react'
const Carprops = (props) => {
  const { car1 } = props
  return (
    <div>
        <h2 style={{ textAlign: 'center', margin: 10 }}>Question no 2</h2><hr />
        <div>Model: {car1.model}</div>
        <div>Comapny: {car1.company}</div>
        <div>Price: {car1.price}</div>
        <div>Color: {car1.configuration.color}</div>
        <div>Fuel: {car1.configuration.fuel}</div>
        <div>Cyinder: {car1.configuration.cylinder}</div>
        <div>FuelTankCapacity: {car1.configuration.fuelTankCapacity}</div>
        <div>City: {car1.configuration.mileage.city}</div>
        <div>Highway: {car1.configuration.mileage.highway}</div>
        <div>Features: <ol><li>{car1.features[0]}</li>
        <li>{car1.features[1]}</li>
        <li>{car1.features[2]}</li>
        <li>{car1.features[3]}</li></ol></div>
        <hr />
    </div>
  )
}

export default Carprops