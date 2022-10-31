// 1. create a component to print the details of following object

// const car = {
// model: 'i20',
// company: 'Hyundai',
// price: 20,
// configuration: {
//  color: 'gray',
//  fuel: 'petrol',
//  cylinder: 4,
//  fuelTankCapacity: 37,
//  mileage: {
//  city: 14,
//  highway: 20,
//  },
//  },
// features: ['touch screen', 'bluetooth', 'alloy wheels', 'power
// steering'],
// }

import React from 'react'
const Car = () => {
    const car = {
        model: 'i20',
        company: 'Hyundai',
        price: 20,
        configuration: {
            color: 'gray',
            fuel: 'petrol',
            cylinder: 4,
            fuelTankCapacity: 37,
            mileage: {
                city: 14,
                highway: 20,
            },
        },
        features: ['touch screen', 'bluetooth','alloy wheels','powersteering'],
    }
  return (
    <div>
        <h2 style={{ textAlign: 'center', margin: 10 }}>Question no 1</h2><hr />
        <div>Model: {car.model}</div>
        <div>Comapny: {car.company}</div>
        <div>Price: {car.price}</div>
        <div>Color: {car.configuration.color}</div>
        <div>Fuel: {car.configuration.fuel}</div>
        <div>Cyinder: {car.configuration.cylinder}</div>
        <div>FuelTankCapacity: {car.configuration.fuelTankCapacity}</div>
        <div>City: {car.configuration.mileage.city}</div>
        <div>Highway: {car.configuration.mileage.highway}</div>
        <div>Features: <ol><li>{car.features[0]}</li>
        <li>{car.features[1]}</li>
        <li>{car.features[2]}</li>
        <li>{car.features[3]}</li></ol></div>
        <hr />
    </div>
  )
}

export default Car