// Libraries
import React, { Component } from "react";
import "./styles/App.scss";
import axios from "axios";

// React-bootstrap
import Container from "react-bootstrap/Container";
import Form from "react-bootstrap/Form";
import Alert from "react-bootstrap/Alert";

// Components
import QuestionForm from "./components/QuestionForm";
import ButtonMenu from "./components/ButtonMenu";

class App extends Component {
  constructor() {
    super();
    this.state = {
      questions: [],
      disabled: true,
      showAlert: false
    };
  }
  updateDisabled = () => {
    this.setState({
      disabled: !this.state.disabled
    });
  };

  handleAnswerChange = e => {
    let controlName = e.target.name;
    let value = e.target.value;

    this.setState(state => {
      const updatedQuestions = state.questions.map(question => {
        if (question.name === controlName) {
          question.value = value;
          return question;
        } else {
          return question;
        }
      });
      return {
        updatedQuestions
      };
    });
  };

  loadData = () => {
    axios
      .get("/api/registrations/")
      .then(res => {
        this.setState({
          questions: res.data
        });
      })
      .catch(error => {});
  };

  clearData = () => {
    this.loadData();
  };
  onShowAlert = () => {
    this.setState({ showAlert: true }, () => {
      window.setTimeout(() => {
        this.setState({ showAlert: false });
      }, 2000);
    });
  };

  submitAnswers = () => {
    axios({
      headers: {
        "Content-Type": "application/json"
      },
      method: "post",
      url: "/api/registrations/",
      data: this.state.questions
    }).then(res => {
      this.onShowAlert();
      this.loadData();
    });
  };

  componentDidMount = () => {
    this.loadData();
  };

  render() {
    return (
      <div className="App">
        <Container>
          <h3>Registracijos Forma</h3>
          <Alert show={this.state.showAlert} variant="success">
            Submit has been successfull
          </Alert>
          <div className="form">
            <Form>
              <QuestionForm
                handleChange={this.handleAnswerChange}
                disabled={this.state.disabled}
                questionData={this.state.questions}
              />
              <ButtonMenu
                disabled={this.state.disabled}
                updateDisabled={this.updateDisabled}
                submitAnswers={this.submitAnswers}
                clearData={this.clearData}
              />
            </Form>
          </div>
        </Container>
      </div>
    );
  }
}

export default App;
