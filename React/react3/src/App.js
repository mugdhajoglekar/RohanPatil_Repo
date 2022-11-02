import "./App.css";
import AdminTable from "./components/AdminTable";
import Navbar from "./components/Navbar";
import Register from "./components/Register";
import {BrowserRouter as Router, Route, Link, Routes} from 'react-router-dom';
// import Routes from 'react-router-dom';

const App = () => {
  return (
    <Router>
      <Navbar />
      {/* <Register /> */}
      <Routes>
        <Route path="/Register" component={Register}></Route>
        <Route path="/AdminTable" component={AdminTable}></Route>
      </Routes>
    </Router>
  );
};

export default App;
