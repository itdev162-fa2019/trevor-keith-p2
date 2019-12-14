import React from 'react';
import axios from 'axios';
import './App.css';

class App extends React.Component {
  state = {
    users: []

  }

  componentDidMount() {
    axios.get('http://localhost:5000/api/values')
      .then((response) => {
        this.setState({
          users: response.data

        })

      })
      .catch((error) => {
        console.error(`Error fetching data: ${error}`)

      })

  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
          Forums

        </header>

        {this.state.users.map((user: any) => <div key={user}>{user}</div>)}

      </div>

    );
  }

}

export default App;
