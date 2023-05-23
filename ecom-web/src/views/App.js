import logo from "./logo.svg";
import "./App.scss";
import Header from "./Header/Header";

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>Hello world!</p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React test first
          <Header />
        </a>
      </header>
    </div>
  );
}

export default App;
