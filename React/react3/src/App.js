import "./App.css";
import AdminTable from "./components/AdminTable";
import Register from "./components/Register";
import Home from "./components/Home"
import Login from "./components/Login"
import AdminLogin from "./components/AdminLogin"
import Reservation from  "./components/Reservation"
import AdminNav from "./components/AdminNav"
import HotelBookings from "./components/HotelBookings"
import Navbar from "./components/Navbar"
import { Route, Link, Routes} from 'react-router-dom';

const App = () => {
  return (
    // <Login />
    <Routes>
      <Route exact path="/" element={<Home />}></Route>
      <Route path="Register" element={<Register />}></Route>
      <Route path="AdminTable" element={<AdminTable />}></Route>
      <Route path="Login" element={<Login />}></Route>
      <Route path="AdminLogin" element={<AdminLogin />}></Route>
      <Route path="AdminNav" element={<AdminNav />}></Route>
      <Route path="Reservation" element={<Reservation />}></Route>
      <Route path="HotelBookings" element={<HotelBookings />}></Route>      
      <Route path="Navbar" element={<Navbar />}></Route>      
    </Routes>
  );
};

export default App;
