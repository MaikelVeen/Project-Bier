import React, { Component } from "react";
import { connect } from "react-redux";
import { clearCart } from '../../actions/actionCreator'
import { StepOrder } from "./StepOrder.js";
import { bindActionCreators } from 'redux'
import {
  Container,
  Button,
  Divider,
} from "semantic-ui-react";

//TODO Refactoring

// TODO after payment, delete guest user info
class Payment extends Component {

  // DO this after payment is confirmed, not before
  componentWillMount() {
    this.props.clearCart();
  }

  state = {}
  handleClick = () => this.setState({ active: !this.state.active })
  handleClick1 = () => this.state.active ? window.location.href = "/confirmation" : alert('Selecteer een betalingswijze alstublieft.')
  render() {
    const { active } = this.state
    return (
      <Container>
        <Divider hidden />
        <StepOrder active={[false, false, true]} />
        <Divider />
        <h2>Kies uw betalingswijze</h2>
        <br />
        <Button toggle active={active} onClick={this.handleClick} style={{ height: "100px", width: "200px" }}><h2>Simulator</h2></Button>
        <Divider hidden />
        <Divider />
        <Button.Group size={'big'}>
          <Button href="/input">Teruggaan</Button>
          <Button.Or text="of" />
          <Button positive onClick={this.handleClick1}>Doorgaan</Button>
        </Button.Group>
      </Container>
    );
  }
}

const mapDispatchToProps = (dispatch) => {
  return bindActionCreators({
    clearCart
  }, dispatch)
}

export default connect(null, mapDispatchToProps)(Payment);
