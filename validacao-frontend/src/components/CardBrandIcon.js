import {
  FaCcVisa,
  FaCcMastercard,
  FaCcAmex,
  FaCcDiscover,
} from "react-icons/fa";

export default function CardBrandIcon({ brand, size = 40 }) {
  const icons = {
    Visa: <FaCcVisa size={size} />,
    MasterCard: <FaCcMastercard size={size} />,
    "American Express": <FaCcAmex size={size} />,
    Discover: <FaCcDiscover size={size} />,
  };

  return icons[brand] || null;
}
