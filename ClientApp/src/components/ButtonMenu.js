import React, { Component } from "react";

import Button from "react-bootstrap/Button";
import ButtonToolbar from "react-bootstrap/ButtonToolbar"

export default class ButtonMenu extends Component {
  render() {
    return (
      <div>
        <ButtonToolbar>
          <Button onClick={this.props.updateDisabled} className="button" variant="primary">
            Koreguoti požymius
          </Button>
          <Button onClick={this.props.submitAnswers} disabled={this.props.disabled} className="button" variant="primary">
            Saugoti taisymus
          </Button>
          <Button onClick={this.props.clearData} disabled={this.props.disabled} className="button" variant="primary">
            Atšaukti pataisymus
          </Button>
        </ButtonToolbar>
      </div>
    );
  }
}
